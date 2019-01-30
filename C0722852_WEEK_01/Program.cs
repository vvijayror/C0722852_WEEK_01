using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0722852_WEEK_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, sum;
            Console.Write("Enter three whole numbers:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            sum = a + b + c;
            Console.Write("The sum is: ={0}", sum);
            Console.ReadKey();
        }
    }
}
