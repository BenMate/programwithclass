using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    class Character : GameObject
    {
        int att;
        int hp;
        int def;

        

        public Character()
        {

        }

        public Character(int att,int hp, int def) : base()
        {
            this.att = att;
            this.hp = hp;
            this.def = def;

        }

        // isAlive() = bool;

    }
}

