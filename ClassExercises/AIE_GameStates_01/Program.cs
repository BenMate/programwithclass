using System;
using System.Collections.Generic;
using Raylib_cs;

namespace AIE_GameStates_01
{
    class Program
    {

        int windowWidth = 800;
        int windowHeight = 450;
        string windowTitle = "GameStateManagement";

        GameState currentGameState;

       public List<ScoreEntry> scores = new List<ScoreEntry>();

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

            scores = new List<ScoreEntry>()
            {
                new ScoreEntry("bob", 102),
                new ScoreEntry("fred", 58),
                new ScoreEntry("ted", 69),
            };

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
