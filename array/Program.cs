using System;

namespace array
{
    class Program
    {
        public static bool Exists(int[] ints, int k)
        {
          bool res = false;
          if (ints[(int)ints.Length/2] == k)
          {
            res= true;
          }
          else if (ints[(int)ints.Length/2] != k && ints.Length == 1)
          {
            res= false;
          }
          else if (ints[(int)ints.Length/2] < k && ints.Length == 2)
          {
            res = false;
          }
          else if (ints[(int)ints.Length/2] < k)
          {
            int[] tmp = new int[(int)(ints.Length-1)/2];
            Array.Copy(ints, (int)ints.Length/2+1, tmp, 0, (ints.Length-1)/2);
            res = Exists(tmp, k);
          }
          else if (ints[(int)ints.Length/2] > k)
          {
            int[] tmp = new int[(int)(ints.Length)/2];
            Array.Copy(ints, 0, tmp, 0, (ints.Length)/2);
            res = Exists(tmp, k);
          }
          return res;

        }
        static void Main(string[] args)
        {
            int[] ints =  {-9, 14, 37, 102};
            Console.WriteLine(Exists(ints, 36));
        }
    }
}
