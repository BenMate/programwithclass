using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_GameStates_01
{
    class GameOverScreen : GameState
    {
        
        int i = 0;
        public GameOverScreen(Program program) : base(program)
        {

        }

        public override void Update()
        {

        }

        public override void Draw()
        {

            //doesnt work

            List<ScoreEntry> scores = new List<ScoreEntry>()
            {
                new ScoreEntry("bob", 102),
                new ScoreEntry("fred", 58),
                new ScoreEntry("ted", 69),


            };

            //for (i = 0; i < scores.Count; ++)
            //{
            //    Raylib.DrawText(scores.ToString(), 10, 10 + 20, 10, Color.ORANGE);  //if statement?? if i = 1 if i = 1? etc

            //}


            Raylib.DrawText("GameOver...", 100, 100, 50, Color.ORANGE);
        }


    }
}

