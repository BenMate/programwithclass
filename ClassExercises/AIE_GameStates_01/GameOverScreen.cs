using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_GameStates_01
{
    class GameOverScreen : GameState
    {
        public GameOverScreen(Program program) : base(program)
        {

        }

        public override void Update()
        {

        }

        public override void Draw()
        {
            for ( i = 0; i < length; i++)
            {
                //todo
            }




            Raylib.DrawText("GameOver...", 100, 100, 50, Color.ORANGE);
        }


    }
}

