using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whatsMyAge
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ask for age
            Console.WriteLine("How old are you?");

            //Obtaine age
            int myAge = Int32.Parse(Console.ReadLine());

            //if under 18
            if (myAge < 18) {
                Console.WriteLine("Go watch a movie youngin'");
            }
               

            //if over 18
            if (myAge >= 18) {
                Console.WriteLine("You can buy lottery tickets!");
            }
                

            //if over 21
            if (myAge >= 21) {
                Console.WriteLine("You can enter a casino in Missouri!");
            }


            //exit program
            Console.ReadKey();


        }
    }
}
