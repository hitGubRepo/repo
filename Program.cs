using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //this is the main function where the algorithim will read the array and sort it in order
        static void Main(string[] args)
        {
            int[] a = { 20, 60, 50, 40, 50, 1, 100, 101 }; //this is the array of numbers

            Console.WriteLine("Original Array: ");

            //this for loop will print out the original array
            foreach (int X in a)
            {
                Console.Write(X + ", ");
            }

            //this for loop will loop through the contents in the array starting from the first number
            for (int p = 0; p <= a.Length - 2; p++)
            {
                //here is another for loop 
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    int t;
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }

            //finally the sorted array is printed out
            Console.WriteLine("\n" + "Sorted array: ");
            foreach (int aa in a)
            {
                Console.Write(aa + ", ");
                //Console.Write("\n");
            }

        }
    }
}
