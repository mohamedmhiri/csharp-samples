using System;

namespace pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var _cutter = new Cutter();
            _cutter.FileReader(args[0]);
        }
    }
}
