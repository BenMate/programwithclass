using System;
using System.Numerics;
using System.Threading;
using Raylib_cs;
namespace AsteroidsWalkThrough
{
    class Program
    {
        public int windowWidth = 1600;
        public int windowHeight = 900;
        public string windowTitle = "asteroids";

        // GameState currentState = null;

        Player player;
        Bullet[] bullets = new Bullet [100];
        Asteroid[] asteroids = new Asteroid[100];

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

            // currentState = new SplashState();

            LoadGame();

            while (!Raylib.WindowShouldClose())
            {
                // update the current state
              //  currentState.Update();

               // Raylib.BeginDrawing();
              //  Raylib.ClearBackground();

                // draw the current state
                //currentState.Draw();

               // Raylib.EndDrawing();

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



       public void Update()

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
            //check all bullets against all asteroids
            foreach (var bullet in bullets)
            {
                foreach (var asteroid in asteroids)
                {
                    DoBulletAsteroidCollision(bullet, asteroid);
                }
            }
            //check player against all asteroids.

            foreach (var asteroid in asteroids)
            {
                DoPlayerAsteroidCollision(player, asteroid);

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
            //trying to make text
          // while (dead = true)
           // {
          //      
          //  }
               
            
                
            
            // draw score ui
            Raylib.DrawText("Score: " + player.score.ToString(), 10, 10, 30, Color.WHITE);

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

            float radius = 40;

            //left wall spawn (asteroid)
            if (side == 0) SpawnAsteroid(new Vector2(0, rand.Next(0, windowHeight)), dir, radius);
            //top wall spawn
            if (side == 1) SpawnAsteroid(new Vector2(rand.Next(0, windowWidth), 0), dir, radius);
            //right wall
            if (side == 2) SpawnAsteroid(new Vector2(windowWidth, rand.Next(0, windowHeight)), dir, radius);
            //bottom wall
            if (side == 3) SpawnAsteroid(new Vector2(rand.Next(0, windowWidth), windowHeight), dir, radius);
        }

        void SpawnAsteroid(Vector2 pos, Vector2 dir, float radius)
        {
            Asteroid asteroid = new Asteroid(this, pos, dir);
            asteroid.radius = radius;

            for (int i = 0; i < asteroids.Length; i++)
            {
                if (asteroids[i] == null)
                {
                    asteroids[i] = asteroid;
                    break;
                }
            }
        }

        // player collision
        void DoPlayerAsteroidCollision(Player player, Asteroid asteroid)
        {
            if (player == null || asteroid == null)
                return;         
             float distance = (player.pos - asteroid.pos).Length();

            
            //trying to make text near player when they collide with asteroid  
            //todo         
          if (distance < asteroid.radius)
          {              
                Raylib.DrawText("BIGBOOM", (int)player.pos.X, (int)player.pos.Y, 100, Color.ORANGE);
               // Thread.Sleep(50);
          }
        }

         void DoBulletAsteroidCollision(Bullet bullet, Asteroid asteroid )
        {
            if (bullet == null || asteroid == null)
                return;
            float distance = (bullet.pos - asteroid.pos).Length();
            if (distance < asteroid.radius)
            {
                player.AddScore(20);

                //making asteroids split
                if (asteroid.radius > 13)
                {
                    SpawnAsteroid(asteroid.pos, asteroid.dir, asteroid.radius / 2);
                    SpawnAsteroid(asteroid.pos, -asteroid.dir, asteroid.radius / 2);
                }
                //find the bullet in the array 
                for (int i=0; i < bullets.Length; i++)
                {
                    if (bullets[i] == bullet)
                    {
                        bullets[i] = null;
                        break;
                    }
                }
                //find the asteroid in the array 
                for (int i = 0; i < asteroids.Length; i++)
                {
                    if (asteroids[i] == asteroid)
                    {
                        asteroids[i] = null;
                        break;
                    }
                } 
                
            }
        }
    }
}
