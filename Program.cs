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
            string UserName;
            string Age;
            string CurrentYear;
            int resultAge;
            int resultYear;
            

            Console.WriteLine("What is your name?");
            UserName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            Age = Console.ReadLine();
            resultAge = Convert.ToInt32(Age);
            
            Console.WriteLine("What is the current year?");
            CurrentYear = Console.ReadLine();
            resultYear = Convert.ToInt32(CurrentYear);

            int BirthYear = resultYear - resultAge;
            Console.WriteLine("Greetings, " + UserName + ". You were born in: "  + BirthYear);




        }
    }
}
