using System;

namespace C_Sharp_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogAge = 10;
            string dogName = "Ralph";
            bool isAwesome = true;
            char one = '1';
            double dbl = 5.5;
            decimal dec = 5.45M;
            Console.WriteLine($@"My dog's name is {dogName},
He is {dogAge} years old, I have had him for {one} year. I want to keep him for {dbl} more years,
but I will likely only keep him for {dec} years."); 
        }
    }
}
