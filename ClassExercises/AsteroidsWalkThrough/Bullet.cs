using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Raylib_cs;
namespace AsteroidsWalkThrough
{
    class Bullet
    {

        Program program;

        public Vector2 pos = new Vector2();
        public Vector2 dir = new Vector2();
        public float speed = 10;


        public Bullet(Program program, Vector2 pos, Vector2 dir)
        {
            this.program = program;
            this.pos = pos;
            this.dir = dir;
        }
        public void Update()
        {
            pos += dir * speed;

            // wrapping the bullet around the screen
            if (pos.X < 0) pos.X = program.windowWidth;
            if (pos.X > program.windowWidth) pos.X = 0;

            if (pos.Y < 0) pos.Y = program.windowHeight;
            if (pos.Y > program.windowHeight) pos.Y = 0;
        }

        public void Draw()
        {                                                                       //change to change the bullet 
            Raylib.DrawLine((int)pos.X, (int)pos.Y, (int)(pos.X - dir.X * speed), (int)(pos.Y - dir.Y * speed), Color.GOLD);

        }

    }
}
