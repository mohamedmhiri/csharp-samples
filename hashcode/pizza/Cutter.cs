using System;
using System.IO;
using System.Text;

namespace pizza
{
    class Cutter
    {
        public Cutter ()
        {}

        public void FileReader(string fileName)
        {
            FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.ReadWrite);
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);

            while (fs.Read(b,0,b.Length) > 0) 
            {
                Console.WriteLine(temp.GetString(b));
            }
            try 
            {
                // Try to write to the file.
                fs.Write(b,0,b.Length);
            } 
            catch (Exception e) 
            {
                Console.WriteLine("Writing was disallowed, as expected: {0}", e.ToString());
            }

        }


    }
}
