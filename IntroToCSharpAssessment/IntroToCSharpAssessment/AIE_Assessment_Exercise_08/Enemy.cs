using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    class Enemy: Character
    {
        int att, hp, def;

        public Enemy()
        {

        }


        public Enemy(int att, int hp, int def) : base()
        {
            this.att = att;
            this.hp = hp;
            this.def = def;
        }


       public void Draw()
        {

        }

    }
}
