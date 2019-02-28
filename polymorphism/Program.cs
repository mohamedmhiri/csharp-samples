using System;

namespace polymorphism
{
    class Class1
    {
      public virtual string test()
      {
        return "ok";
      }
    }
    class Class2 : Class1
    {
      public override string test()
      {
        return "no";
      }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class2();
            Console.WriteLine(obj.test());
        }
    }
}
