using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ');

            for (int i = 0; i < elements.Length / 2; i++)
            {
                string firstElement = elements[i];
                string lastElement = elements[(elements.Length - 1) - i];

                elements[i] = lastElement;
                elements[(elements.Length - 1) - i] = firstElement;

            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
