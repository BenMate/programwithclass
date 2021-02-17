using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_GameStates_01
{
    class PlayGameScreen : GameState
    {

        int buttonPressCount = 0;

        public PlayGameScreen(Program program) : base(program)
        {

        }

        public override void Update()
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
            {
                buttonPressCount += 1;
            }

        }
        public override void Draw()
        {
            Raylib.DrawText("PlayGame Screen", 10, 10, 20, Color.GRAY);
            Raylib.DrawText($"Press Count {buttonPressCount}", 10, 30, 50, Color.GRAY);
        }
    }
}
