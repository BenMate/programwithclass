using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
        class Room
         {
        //game object
        GameObject[] objects = new GameObject[3];


        //AddGameObject 

        public void AddGameObject(GameObject gameObject)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i] == null)
                {
                    objects[i] = gameObject;
                    break;
                }
            }
        }

        //remove game object

            public void RemovingObject(GameObject gameObject)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i] == gameObject)
                {
                    objects[i] = null;

                    objects.OrderByDescending(obj => (obj == null ? 0 : 1)).ToArray();
 
                    break;
                }
            }
        }


        //draw
        public void Draw()
        {

            if (objects[0] == null) Console.Write("_");
            else objects[0].Draw();
            
            //same as below

            //for (int i = 0; i < objects.Length; i++)
            //{
            //    if (objects[i] == null)
            //    {

            //        Console.Write("_");
            //         break;
                    
            //    }


            //     else if (objects[i] != null)
            //    {
            //        objects[i].Draw();
            //         break;
                    
            //    }
            //}
        }
    }
}
