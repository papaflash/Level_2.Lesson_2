using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics;

namespace MyGameAsteroids
{
    interface ICollision
    {
        bool Collision(ICollision obj);
        Rectangle Rect { get; }
    }
    static class Game
    {
        static readonly Size _maxSize = new Size(1280, 720);
        private static Bullet _bullet;
        private static Asteroid[] _asteroids;
        private static SpaceShip _spaceShip;
        static List<Pen> lsPens = new List<Pen>() {Pens.White, Pens.Red, Pens.Aquamarine, Pens.Blue, Pens.Coral };
        static Random r = new Random();
        private static BaseObject[] _objs;
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;
        private static int _width;
        /// <summary>
        ///Уровень_2.Урок_2.Задание_4: реализация проверки на допустимые размеры экрана, выбросить исключение ArgumentOutOfRangeException().
        /// </summary>
        public static int Width 
        {
            set
            {
                if (value < _maxSize.Width && value > 0) _width = value;
                else throw new ArgumentOutOfRangeException("Width");
            }
            get { return _width; }
        }
        private static int _height;
        public static int Height
        {
            set
            {
                if (value < _maxSize.Height && value > 0) _height = value;
                else throw new ArgumentOutOfRangeException("Height");
            }
            get { return _height; }
        }
        static Game() { }

        public static void Init(Form form)
        {
            
            Graphics g;
            _context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));
            Load();
            Timer timer = new Timer { Interval = 50};
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
            Update();
        }

        public static void Draw()
        {
            Buffer.Graphics.Clear(Color.Black);
            
            Buffer.Graphics.FillEllipse(Brushes.Aquamarine, new Rectangle(50, 50, 200, 200));
           

            //Buffer.Graphics.Clear(Color.Black);
            foreach (BaseObject obj in _objs)
                obj.Draw();
            foreach (BaseObject aster in _asteroids)
                aster.Draw();
            _bullet.Draw();
            _spaceShip.Draw();
            Buffer.Render();
        }
        public static void Load()
        {
            _objs = new BaseObject[80];
            _asteroids = new Asteroid[10];
            //оборочиваем в try catch для обработки своего исключения
            try
            {
                for (int i = 0; i < _asteroids.Length; i++)
                {
                    _asteroids[i] = new Asteroid(new Point(r.Next(200, 600), 2), new Point(5 + i, 5 + i), new Size(20, 20), lsPens[r.Next(0, 5)]);
                }
            }catch(MyExceptions.GameObjectException err)
            {
                Debug.WriteLine(err.Message);
            }
            for (int i = 0; i < _objs.Length; i++)
            {
                _objs[i] = new Star(new Point(r.Next(1, 1280), r.Next(1, 740)), new Point(-i - 1, 0), new Size(2, 2), lsPens[r.Next(0, 4)]);
            }
            _bullet = new Bullet(new Point(265, 350), new Point(5, 0), new Size(20, 2), Pens.Orange);
            _spaceShip = new SpaceShip(new Point(200, 350), new Point(0, 2), new Size(80, 60), null);
            
        }
        public static void Update()
        {
            foreach (BaseObject obj in _objs)
                obj.Update();
            foreach (var aster in _asteroids)
            {
                aster.Update();
                if (aster.Collision(_bullet)) { 
                    System.Media.SystemSounds.Hand.Play();
                    aster.Resurrection(Width); //метод восстановления уничтоженного астероида
                    _bullet.Resurrection(_spaceShip);  //метод нового выстрела после попадения в астероид
                }
            }
            _bullet.Update();
            _spaceShip.Update(); 
        }
    }
}
