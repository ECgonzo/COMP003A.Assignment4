/*
 * Author: Ethen Gonzalez
 * Course: COMP-003A
 * Purpose: Replicate looping statements output
 */

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("for loop Section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("*******************************************************************");

            Console.Write("Enter a positive whole number: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            string output = "#";

            Console.WriteLine("Right Triangle:");
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(output);
                output += "#";
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("foreach Section");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("*******************************************************************");

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };
            Console.WriteLine("\nFriends:");
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("dowhile Section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("*******************************************************************");

            int counter = 0;
            Console.WriteLine("\nCounting by 5s:");
            do
            {
                Console.WriteLine(counter);
                counter += 5;
            } while (counter <= 50);
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            Console.WriteLine("*******************************************************************");
            Console.WriteLine("while Section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If number is divisible by 2, output Foo");
            Console.WriteLine("If number is divisible by 5, output Bar");
            Console.WriteLine("If number is divisible by 2 & 5, output FooBar");
            Console.WriteLine("*******************************************************************");

            int counter2 = 1;
            Console.WriteLine("\nFooBar:");
            while (counter2 <= 20)
            {
                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                else
                {
                    Console.WriteLine(counter2);
                }
                counter2++;
            }
        }
    }
}
