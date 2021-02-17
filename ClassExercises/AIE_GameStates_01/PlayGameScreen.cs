using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_GameStates_01
{
    class PlayGameScreen : GameState
    {
        float cooldownTimer = 10.0f;
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
            cooldownTimer -= Raylib.GetFrameTime();
            if (cooldownTimer < 0)
            {
                program.ChangeGameState(new GameOverScreen(program));
            }

        }
        public override void Draw()
        {
            Raylib.DrawText("PlayGame Screen", 10, 10, 20, Color.GRAY);
            Raylib.DrawText($"Press Count {buttonPressCount}", 10, 200, 50, Color.GRAY);
            Raylib.DrawText($"TIME LEFT!!!! {cooldownTimer}", 10, 30, 50, Color.GRAY);
        }
    }
}
