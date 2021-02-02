using System;

namespace AIE_04temp
{
    class Program
    {
        static void Main(string[] args)
        {


            float celcius = 24;

            //Divide by 5, the multiply by 9, then add 32 

            float calciustofarrenhieght = (celcius / 5.0f) * 9.0f + 32f; //yes you spelt fahrenheit wrong but that doesnt matter.

            Console.WriteLine($" {celcius} is {calciustofarrenhieght} Fahrenheit");



            // Deduct 32, the multiply by 5, then divide by 9.
            float farrenhieghttocelcuis = (calciustofarrenhieght - 32) *5.0f / 9.0f;

            Console.WriteLine($" {calciustofarrenhieght} Fahrenheit is {farrenhieghttocelcuis} Celsius");
     









        }
    }
}
