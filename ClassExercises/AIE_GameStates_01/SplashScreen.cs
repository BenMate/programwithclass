using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace AIE_GameStates_01
{
    class SplashScreen : GameState
    {

        float cooldownTimer = 5.0f;

        public SplashScreen(Program program) : base(program)
        {

        }

        public override void Update()
        {
            cooldownTimer -= Raylib.GetFrameTime();
            if (cooldownTimer < 0)
            {
                program.ChangeGameState(new MenuScreen(program));
            }
        }
        //this says splash screen on the screen
        public override void Draw()
        {
            Raylib.DrawText("Splash Screen vivid is dumb", 10, 10, 20, Color.GRAY);
            Raylib.DrawText("game is loading...", 100, 100, 20, Color.GRAY);
        }
        

    }
}
