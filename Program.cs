using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3a_Console_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int currentYear, age;
            int int1, int2, int3;
            double distance1, distance2, distance3;
            double trilength1, trilength2, answer;


            //1 Greetings
            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What is the current year?");
            currentYear = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Greetings, " + userName + ". You were born in: " +(currentYear - age));



            //2 Adding
            Console.WriteLine("Please type an integer:");
            int1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please type another integer:");
            int2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("One more:");
            int3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your Total is: " + (int1 + int2 + int3));


            
            //3 Distance
            Console.WriteLine("Please input your first distance:");
            distance1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input your second distance:");
            distance2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input your last distance:");
            distance3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your average distance is " + (Math.Round((distance1 + distance2 + distance3) / 3,2)));



            //4 Hypotenuse
            Console.WriteLine("Please enter the first side length of the triangle: ");
            trilength1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second side length of the triangle: ");
            trilength2 = Convert.ToDouble(Console.ReadLine());

            answer = Math.Pow(trilength1,2) + Math.Pow(trilength2,2);
            Console.WriteLine("The hypotenuse is: " + Math.Round(Math.Sqrt(answer),2));

        }
    }
}
