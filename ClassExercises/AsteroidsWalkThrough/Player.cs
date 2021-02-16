using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AsteroidsWalkThrough
{
    class Player : GameObject
    {
        public Vector2 size = new Vector2(64, 64);

        public int score = 0;


        public float rotationSpeed = 5.0f;

        public float accelerationSpeed = 0.1f;

        public Vector2 velocity = new Vector2();

        public Player(Program program, Vector2 pos, Vector2 size) : base(program, pos)
        {
            this.size = size;
        }

       public override void Update()
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A) || Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                Rotate(-rotationSpeed);
                

            if (Raylib.IsKeyDown(KeyboardKey.KEY_D) || Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) //makes it so when the player presses a key, an action accurs
                Rotate(rotationSpeed);

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W) || Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                var dir = GetFacingdirection();
                velocity += dir * accelerationSpeed;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_S) || Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                var dir = GetFacingdirection();
                velocity -= dir * accelerationSpeed;
            }
            // add velocity to poistion (you dont move without this)
            pos += velocity;
            // wrapping the player around the screen
            if (pos.X < 0) pos.X = program.windowWidth;
            if (pos.X > program.windowWidth) pos.X = 0;

            if (pos.Y < 0) pos.Y = program.windowHeight;
            if (pos.Y > program.windowHeight) pos.Y = 0;

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
            {
                program.SpawnBullets(pos, GetFacingdirection());
                
            }
        }

        public Vector2 GetFacingdirection()
        {
            return dir;
        }

        public override void Draw()
        {
            var texture = Assets.shipTexture;

            Raylib.DrawTexturePro(
                texture,
                new Rectangle(0, 0, texture.width, texture.height),
                new Rectangle(pos.X, pos.Y, size.X, size.Y),
                new Vector2(0.5f * size.X, 0.5f * size.Y),    //play around with this, (pivit point of asteroids
                GetRotation(),
                Color.GOLD);
        }


        public void AddScore(int amount)
        {
            score += amount;




        }

    }
}

