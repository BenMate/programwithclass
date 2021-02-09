using System;
using System.Numerics;
using Raylib_cs;
namespace AsteroidsWalkThrough
{
    class Program
    {
        public int windowWidth = 800;
        public int windowHeight = 450;
        public string windowTitle = "asteroids";

        Player player;
        Bullet[] bullets = new Bullet [100];
        Asteroids[] asteroids = new Asteroids[100];

        float asteroidSpawnCooldown = 4.0f;
        float asteroidSpawnCooldownReset = 4.0f;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.RunGame();
        }

        void RunGame()
        {
            Raylib.InitWindow(windowWidth, windowHeight, windowTitle);
            Raylib.SetTargetFPS(60);

            LoadGame();

            while (!Raylib.WindowShouldClose())
            {
                Update();
                Draw();
            
            }

            Raylib.CloseWindow();
        }
     
             void LoadGame()
           {
            Assets.LoadAssets();
            //todo initialise all other things

            player = new Player(
                this,
                new Vector2(windowWidth / 2, windowHeight / 2),
                new Vector2(64, 64)
                );

            //initialise bullets null
            for (int i=0; i < bullets.Length; i++)
             {
                bullets[i] = null;

             }

            //initialise asteroids
            for (int i = 0; i < asteroids.Length; i++)
            {
                asteroids[i] = null;
            }



           }



        void Update()

        {
            asteroidSpawnCooldown -= Raylib.GetFrameTime();
            if (asteroidSpawnCooldown < 0.0f)
            {
                SpawnNewAsteroid();
                asteroidSpawnCooldown = asteroidSpawnCooldownReset;
            }

            player.Update();


            //update all bullets
            for (int i = 0; i < bullets.Length; i++)
            {
                if( bullets[i] != null)
                {
                bullets[i].Update();
                }                
            } //updates the asteroids
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (asteroids[i] != null)
                {
                    asteroids[i].Update();
                }
            }

        }








        void Draw()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DARKGRAY);

            player.Draw();
            //draws bullets
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] != null)
                {
                    bullets[i].Draw();
                }
            }
            //Draws the asteroids
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (asteroids[i] != null)
                {
                    asteroids[i].Draw();
                }
            }


            Raylib.EndDrawing();
        }

        public void SpawnBullets(Vector2 pos, Vector2 dir)
         {

            //spawns bullets into game.
            Bullet bullet = new Bullet(this, pos, dir);
            for (int i=0; i < bullets.Length; i++)
            {
                if (bullets[i] == null)
                {
                    bullets[i] = bullet;
                    break;
                }
            }
         }

        //generates a random spot for asteroids
        void SpawnNewAsteroid()
        {
            Random rand = new Random();
            int side = rand.Next(0, 4);

            float rot = (float)rand.NextDouble() * MathF.PI * 2.0f;
            Vector2 dir = new Vector2(MathF.Cos(rot), MathF.Sin(rot));



            //left wall spawn (asteroid)
            if (side == 0) SpawnAsteroid(new Vector2(0, rand.Next(0, windowHeight)), dir);
            //top wall spawn
            if (side == 1) SpawnAsteroid(new Vector2(rand.Next(0, windowWidth), 0), dir);
            //right wall
            if (side == 2) SpawnAsteroid(new Vector2(windowWidth, rand.Next(0, windowHeight)), dir);
            //bottom wall
            if (side == 3) SpawnAsteroid(new Vector2(rand.Next(0, windowWidth), windowHeight), dir);
        }

        void SpawnAsteroid(Vector2 pos, Vector2 dir)
        {
            Asteroids asteroid = new Asteroids(this, pos, dir);
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (asteroids[i] == null)
                {
                    asteroids[i] = asteroid;
                    break;
                }
            }
        }
    }
}
