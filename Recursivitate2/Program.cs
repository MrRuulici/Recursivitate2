using System;

namespace Recursivitate2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[] { 5, 6, 7, 8, 3, 2, 10, 2 };
            Console.WriteLine(Recursiv.Maxim(v, v.Length-1, int.MinValue)) ;
        }
    }
}
