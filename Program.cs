using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Developer: Orraymiosiris H. Guevara.
 * C# Visual Studio Console Calculator APP.
 * Description: This program displays a MENU with the 4 basics operation 
 * [+*-/]. It makes the user to choose a number from {1-4} and keeps asking over and over untit the user makes the right input.
 * When the user chose the operation the calculator will prompt a message with the ongoing operation will ask for the 2 numbers
 * to be calcalated depending on the operation already choose.
 * The program consists of a Menu and  4 function for each operation.
*/
namespace ProCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            string q = "yes";
           
            do
            {
                try
                {
                    Console.Clear();
                    Calculator.Procalculator();
                    Console.WriteLine("\nType [yes] and then enter to go back to the main menu or any other key + enter to fully exit the program:");
                    q = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Thank you for being an amazing user!");
                }
            } while ((q == "yes"));
           
            Console.WriteLine("Thank you for being an amazing user!");
            Console.ReadKey(true);
        }
        
    }

}