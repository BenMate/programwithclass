using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace AsteroidsWalkThrough
{
    class Assets
    {
        public static Texture2D shipTexture;

        public static void LoadAssets()
        {
            shipTexture = Raylib.LoadTexture("./assets/ship.png");
        }

    }
}
