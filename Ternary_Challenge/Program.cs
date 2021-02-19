using System;

namespace Ternary_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //takes a temperature value as input and checks if the input is an integer or not

            int temp;
            bool check;
            Console.WriteLine("What is the temperature in Celcius?");
            string tempCheck = Console.ReadLine();

            check = int.TryParse(tempCheck, out temp); 

            if (check)
            {
                CheckWeather(temp);
            }
            else
            {
                Console.WriteLine("That is not a valid temperature!");
            }
            
            
           
        }

        public static void CheckWeather(int temp)
        {
            string message = temp <= 15 ?
            "it is too cold here" :
            (temp >= 16 && temp <= 28) ?
            "it is ok" :
            "it is hot here";

            Console.WriteLine(message);
        }
    }
}
