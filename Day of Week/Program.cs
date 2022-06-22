using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            string[] days =
            {
                "Monday", //0
                "Tuesday", //1
                "Wednesday", //2
                "Thursday", //3
                "Friday", //4
                "Saturday", //5
                "Sunday" //6
            };
            if (dayOfWeek >= 1 && dayOfWeek <= 7)
            {
                Console.WriteLine(days[dayOfWeek-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
