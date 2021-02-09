using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Raylib_cs;

namespace AsteroidsWalkThrough
{
    class Asteroids
    {
        Program program;

        public Vector2 pos = new Vector2();
        public Vector2 dir = new Vector2();
        public float radius = 40;

        public Asteroids(Program program, Vector2 pos, Vector2 dir)
        {
            this.program = program;
            this.pos = pos;
            this.dir = dir;

        }
        public void Update()
        {
            pos += dir;
        }

        public void Draw()
        {

            Raylib.DrawCircleLines((int)pos.X, (int)pos.Y, radius, Color.WHITE);
        }




    }
}
