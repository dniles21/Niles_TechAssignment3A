using System;
/*
 * Danie Niles
 * 9/24/2020
 * Purpose: To have two methods that pass information between eachother to 
 * display a users inputted name.
 */
namespace Niles_TechAssignment3A
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Prompt
            Console.WriteLine("Hello, Please input your name!");
            //User input is recorded
            string Userinput = Console.ReadLine();
            //This calls on the other method, named ReturnName
            ReturnName(Userinput);
        }
        //This is the second method
        private static void ReturnName(string Userinput)
        {
            //Here the greetings is combined with the recorded name and displayed
            Console.WriteLine("Hello " + Userinput);
        }
    }
}
