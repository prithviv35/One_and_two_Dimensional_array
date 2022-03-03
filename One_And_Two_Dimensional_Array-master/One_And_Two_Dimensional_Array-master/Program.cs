using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_And_Two_Dimensional_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring single dimensional array
            string[] Books = new string[5];
            Books[0] = "C#";
            Books[1] = "Java";
            Books[2] = "VB.NET";
            Books[3] = "C++";
            Books[4] = "C";

            Console.WriteLine("All the element of Books array is:\n");

            //Formatting Output
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("{1}. {0}\t", Books[i-1],i);
            }
            Array.Sort(Books);
            foreach (String s in Books)
            {
                Console.WriteLine(s);  
            }

            //initializing 2D array
            int[,] numbers = { { 2, 3 }, { 4, 5 } };

            // access first element from the first row
            Console.WriteLine("Element at index [0, 0] : " + numbers[0, 0]);

            // access first element from second row
            Console.WriteLine("Element at index [1, 0] : " + numbers[1, 0]);

            Console.ReadLine();

        }
    }
}
