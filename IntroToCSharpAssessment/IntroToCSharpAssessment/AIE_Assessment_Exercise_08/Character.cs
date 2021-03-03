using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    public abstract class Character : GameObject
    {
        public int att;
        public int hp;
        public int def;

        public Character() : base ()

        {

        }

        public Character(int att,int hp, int def) : base()
        {
            this.att = att;           
            this.def = def;
            this.hp = hp;

        }
        
        
        public bool IsAlive()
        {      
            if (hp >= 0)
            {

                return false;
            }
            return true;
        }
              
    }
}

