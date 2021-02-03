using System;
using System.Numerics;
using Raylib_cs;
namespace RaylibPong
{
    class Ball 
    {
        Vector2 pos = new Vector2();
        Vector2 dir = new Vector2();
        float speed = 1.0f;
        float radius = 10.0f;
    }

    class Program
    {
        Ball ball;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.RunProgram();
        }
            void RunProgram()
            {
                Raylib.InitWindow(800, 450, "Pong");

                LoadGame();

                while (Raylib.WindowShouldClose())
                {
                    //Update logic

                    Update();
                    Draw();

                    

                }
                Raylib.CloseWindow();
            }
        void LoadGame()
        {


        }

        void Update()
        {


        }

        void Draw()
        {
            //drawing logic
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DARKGRAY);
            Raylib.EndDrawing();

        }
    }
}