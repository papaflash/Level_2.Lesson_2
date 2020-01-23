using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MyGameAsteroids
{
    class Bullet : BaseObject
    {
        public Bullet(Point pos, Point dir, Size size, Pen pen) : base(pos, dir, size, pen) { }
        public override void Draw()
        {
            Game.Buffer.Graphics.DrawRectangle(MyPen, Pos.X, Pos.Y, Size.Width, Size.Height);
        }
        public override void Update()
        {
            Pos.X += 10;
        }
        public void Resurrection(SpaceShip ship)
        {
            Pos.X = ship.Rect.X + 65;
            Pos.Y = ship.Rect.Y;
        }
    }
}
