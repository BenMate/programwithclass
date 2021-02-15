using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Raylib_cs;

namespace AsteroidsWalkThrough
{
    class Asteroid : GameObject
    {
        
        public float radius = 40;

        public Asteroid(Program program, Vector2 pos, Vector2 dir) : base(program, pos, dir)
        {
        }
        public override void Update()
        {
            pos += dir;
            if (pos.X < 0) pos.X = program.windowWidth;
            if (pos.X > program.windowWidth) pos.X = 0;

            if (pos.Y < 0) pos.Y = program.windowHeight;
            if (pos.Y > program.windowHeight) pos.Y = 0;
        }

        public override void Draw()
        {

            Raylib.DrawCircleLines((int)pos.X, (int)pos.Y, radius, Color.GREEN);
            
        }




    }
}
