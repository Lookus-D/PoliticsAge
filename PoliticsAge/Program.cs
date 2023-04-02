using System;

namespace PoliticsAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your age, please.");
            string age = Console.ReadLine();
            int chosenAge = 0;
            Int32.TryParse(age, out chosenAge);
            
            if (chosenAge >= 21) 
            {
                Console.WriteLine("You are ready to become a politics!");
            }
            else
            {
                Console.WriteLine("Sorry, you are to young yet!");
            }
        }
    }

}
