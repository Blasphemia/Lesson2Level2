using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Hi, bastard! Let's play! Try to guess the number I generated :)");
            
           
            bool helper = true;
            
            while (helper == true) 
            {
                
                Ugadajka();
                Console.WriteLine("Do you want to play again? y/n");
                string playAgain = Console.ReadLine();

                if (playAgain == "n") { helper = false; }
                else if ((playAgain != "y") && (playAgain !="n"))
                {
                    Console.WriteLine("Incorrect input!!"); break;
                }

            } 


            Console.WriteLine("Bye-bye, sick bastard! =)");














            Console.ReadLine();


        }

        static void Ugadajka()
        {
            Random rand = new Random();
            int number = rand.Next(1, 5);


            Console.WriteLine("Enter the number: ");
            int enterNumber = Convert.ToInt32(Console.ReadLine());

            while (enterNumber != number)
            {


                if (enterNumber < number)
                {
                    Console.WriteLine("Enter a larger numberr ! ");
                    enterNumber = Convert.ToInt32(Console.ReadLine());
                }
                else if (enterNumber > number)
                {
                    Console.WriteLine("Enter a lower number!");
                    enterNumber = Convert.ToInt32(Console.ReadLine());
                } 

            }
            Console.WriteLine("Krosavcheg!!!  ");
            Console.WriteLine("i guess " + number);
            
            
        }


    }
    

}
