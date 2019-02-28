using System;
using System.IO;

namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
          var file = Directory.GetFiles("/home/mohamed/Documents", "React_Quickly.pdf", SearchOption.AllDirectories);
/*
          DirectoryInfo d = new DirectoryInfo();//Assuming Test is your Folder
          FileInfo[] Files = d.GetFiles("*.html"); //Getting Text files
          string str = "";
          foreach(FileInfo file in Files )
          {
          str = str + ", " + file.Name;

          }
          */
          if (file != null)
          {
            Console.Write(file[0]);
          }
        }
    }
}
