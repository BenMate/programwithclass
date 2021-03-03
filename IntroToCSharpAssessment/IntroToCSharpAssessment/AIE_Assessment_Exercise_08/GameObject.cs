using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    public abstract class GameObject
    {
        public int xPosition;
        public int yPosition;


        public GameObject()
        {

        }

        public GameObject(int xPosition, int yPosition) 
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }


        public virtual void Draw()
        {
            
        }
    }
}
