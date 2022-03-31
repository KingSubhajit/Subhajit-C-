using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            int t = n;
            while (n > 0)
            {
                s = (s*10)+ (n % 10);
                n = n / 10;
            }
            if(t==s)
            {
                Console.WriteLine("This no is Palindrome");
            }
            else
            {
                Console.WriteLine("This no is non Palindrome");
            }
            Console.ReadLine();
        }
    }
}
