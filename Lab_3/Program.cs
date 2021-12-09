using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static int ReverseNumber(int num)
        {                     
            int s = 0;
            while (num > 0)
            {
                s = s * 10 + num % 10;
                num /= 10;
            }
            return s;
        }
        static bool IsReverse(int a)
        {            
            return ReverseNumber(a) == a;
        }
        static void PrintAllNumbers(int x)
        {
            StringBuilder a = new StringBuilder();
            for(int i = 0; i < x; i++)
            {
                if (IsReverse(i) && IsReverse(i * i)) 
                    a.Append(i+"\n");                
            }
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            PrintAllNumbers(n);
            Console.ReadLine();
        }
    }
}
