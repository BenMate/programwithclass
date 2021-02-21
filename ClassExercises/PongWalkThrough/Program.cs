using System;
using System.Numerics;
using Raylib_cs;

namespace PongWalkThrough
{

    class Ball
    {
       public Vector2 pos = new Vector2();
       public Vector2 dir = new Vector2();
        
       public float radius = 10.0f; //set size of ball
       public float speed = 5.0f;  //sets speed of ball

    }
    class Paddle
    {

        //create the sizing and controlls for paddles
        public Vector2 pos = new Vector2();
        public Vector2 size = new Vector2(10, 100);
        public float speed = 5.0f;
        public KeyboardKey upKey;
        public KeyboardKey downKey;
        public int score = 0;


    }



    class Program
    {
        int windowWidth = 1600;
        int windowHeight = 900;

        Ball ball;
        Paddle leftPaddle;
        Paddle rightPaddle;



        static void Main(string[] args)
        {
            Program p = new Program();
            p.RunProgram();
        }

        void RunProgram()
        {
            Raylib.InitWindow(windowWidth, windowHeight, "Pong");
             Raylib.SetTargetFPS(120); //sets fps

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
            ball = new Ball();
            ResetBall();
            
            ball.dir.X = 0.707f;
            ball.dir.Y = 0.707f;

            leftPaddle = new Paddle();
            leftPaddle.pos.X = 10;
            leftPaddle.pos.Y = windowHeight / 2.0f;
            leftPaddle.upKey = KeyboardKey.KEY_W;
            leftPaddle.downKey = KeyboardKey.KEY_S;

            rightPaddle = new Paddle();
            rightPaddle.pos.X = windowWidth - 10;
            rightPaddle.pos.Y = windowHeight / 2.0f;
            rightPaddle.upKey = KeyboardKey.KEY_UP;
            rightPaddle.downKey = KeyboardKey.KEY_DOWN;
        }



        void ResetBall ()
        {
            ball.pos.X = windowWidth / 2;
            ball.pos.Y = windowHeight / 2;

        }

        void Update()
        {
            //update the logic 
            //  ball.pos.X += ball.dir.X * ball.speed;
            //  ball.pos.Y += ball.dir.Y * ball.speed;

            UpdateBall(ball);
            UpdatePaddle(leftPaddle);
            UpdatePaddle(rightPaddle);

            HandlePaddleBallCollision(leftPaddle, ball);
            HandlePaddleBallCollision(rightPaddle, ball);
        }

        void UpdateBall(Ball b)
        {
            b.pos += b.dir * b.speed;

            //makes ball bounce off walls

            if (b.pos.X < 0)
            {
                ResetBall();
                rightPaddle.score += 1;
            }
            if (b.pos.X > windowWidth)
            {
                ResetBall();
                leftPaddle.score += 1;
            }
            if (b.pos.Y < 0)                b.dir.Y = -b.dir.Y;
            if (b.pos.Y > windowHeight)     b.dir.Y = -b.dir.Y;
        }


        void HandlePaddleBallCollision (Paddle p, Ball b)
        {
            float top = p.pos.Y - p.size.Y / 2;
            float bottom = p.pos.Y + p.size.Y / 2;
            float right = p.pos.X + p.size.X / 2;
            float left = p.pos.X - p.size.X / 2;

            //ball is over lapping paddle 
            if (b.pos.Y > top && ball.pos.Y < bottom && b.pos.X > left && b.pos.X < right)               
                b.dir.X = -b.dir.X;

        }
       
        void UpdatePaddle (Paddle p )
        {
            if (Raylib.IsKeyDown(p.upKey))
            {
                p.pos -= new Vector2(0, p.speed);
            }
            //moves paddle up and down
            if ( Raylib.IsKeyDown(p.downKey))
            {
                p.pos += new Vector2(0, p.speed);
            }

            if (p.pos.Y > windowHeight)
            {
                p.pos.Y = windowHeight;
            }
            if (p.pos.Y < 0)
            {
                p.pos.Y = 0;
            }

            // if (pos.X < 0) pos.X = Paddle.windowWidth;
            // if (pos.X > Paddle.windowWidth) pos.X = 0;

           // if (pos.Y < 0) pos.Y = p.windowHeight;
           // if (pos.Y > p.windowHeight) pos.Y = 0;
        }

        void Draw()
        {
            //drawing logic
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DARKGRAY);
            Raylib.EndDrawing();

            Raylib.DrawFPS(10, 10);

            DrawBall(ball);
            DrawPaddle(leftPaddle);
            DrawPaddle(rightPaddle);

            Raylib.DrawText(leftPaddle.score.ToString(), windowWidth / 4, 20, 20, Color.RAYWHITE); //draws left paddle scrore
            Raylib.DrawText(rightPaddle.score.ToString(), windowWidth - (windowWidth / 4), 20, 20, Color.RAYWHITE); //draws right paddles score
        }
        void DrawBall(Ball b)
        {
            Raylib.DrawCircle((int)b.pos.X, (int)b.pos.Y, b.radius, Color.RAYWHITE);
        }

        void DrawPaddle(Paddle p)
        {
            Raylib.DrawRectanglePro(new Rectangle(p.pos.X, p.pos.Y, p.size.X, p.size.Y), p.size / 2 ,0.0f, Color.RAYWHITE);

        }


    }
}
