using System;

namespace types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] ints = {1, 2, 3};
            for (var i = 0; i < ints.Length; i ++) {
                Console.Write(ints[i]);
            }

        }
    }
}
