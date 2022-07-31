using System;

namespace Lab7
{
    class Lab7A
    {
        static void Main(string[] args)
        {
            string uI;
            int num = 0;

            // user input statement
            Console.Write("Please enter a value for the size: ");
            uI = Console.ReadLine();
            num = Convert.ToInt32(uI);

            // print statements 
            Console.WriteLine("This is the requested "+ num + " x " + num + "  right-triangle: ");

            // for loop and nested for loop to print rows and columns 
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                    Console.Write("\n");
            }


        }
    }
}
