using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MyGameAsteroids.Properties;

//Добавил свой класс корабль

namespace MyGameAsteroids
{
    class SpaceShip: BaseObject
    {
       
        private Image _image = Resources.cb;
        public SpaceShip(Point pos, Point dir, Size size, Pen pen) : base(pos, dir, size, pen)
        {

        }
        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(_image, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        public override void Update()
        {
            Pos.Y += -Dir.Y;
            if (Pos.Y >= 400) Dir.Y = -Dir.Y;
            if (Pos.Y <= 300) Dir.Y = -Dir.Y;
        }

    }
}
