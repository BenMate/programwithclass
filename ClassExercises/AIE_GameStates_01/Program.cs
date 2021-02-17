using System;
using Raylib_cs;

namespace AIE_GameStates_01
{
    class Program
    {

        int windowWidth = 800;
        int windowHeight = 450;
        string windowTitle = "GameStateManagement";

        GameState currentGameState;

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
            //load assets, files sounds imagies etc

            //changes the gamestate  
            currentGameState = new SplashScreen(this);
        }
            
        void Update()
        {
            if (currentGameState != null)
                currentGameState.Update();

        }

        void Draw()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.RAYWHITE);

            if (currentGameState != null)
                currentGameState.Draw();

            Raylib.DrawFPS(10, windowHeight - 20);
            Raylib.EndDrawing();
        }
            
            public void ChangeGameState(GameState newGameState)
        {
            currentGameState = newGameState;
        }



    }
}
