using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /*------Adding a string------------*/
            string name = "kazeem";
            string first = "Jhon";
            string value = name + first;
            Console.WriteLine(value);
            /*-------printing rigth agle trangle---------------- */
            int num1 = 6;
            for (int i = num1; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("5");
                }
                Console.WriteLine();
            }

            /*------Printing star right angle trangle----------*/

            int num = 6;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            /*------reverse of string------------*/
            Console.WriteLine("Enter the string name :");
            string name1 = Console.ReadLine();

            char[] s1 = name1.ToCharArray();
            string Reverse = String.Empty;
            for (int i = s1.Length - 1; i > -1; i--)
            {
                Reverse += s1[i];
            }
            Console.WriteLine(Reverse);
            /*--------adding two variable------*/
            int x = 25;
            int y = 55;
            int z = x + y;
            Console.WriteLine(z);







        }
    }
}
