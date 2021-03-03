using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    class Enemy: Character
    {
        int hp = 10;
        int att;
        int def;

       
        public Enemy() : base ()
        {

        }

        public Enemy(int att, int hp, int def) : base(att,hp,def)
        {
            this.att = att;
            this.hp = hp;
            this.def = def;
        }
         

       public override void Draw()
        {
            if (hp >= 10)
            {
                Console.Write("O");

            }
            else
            {
                Console.Write("o");
            }
        }
    }
}
