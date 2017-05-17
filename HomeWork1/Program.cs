using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeForkWriteToTheFile
{
   
     
    class Program
    {
        public static void Write(string stroka)
        {
            using (StreamWriter file = new StreamWriter("Filee.txt", true))
            {
                file.WriteLine(stroka);
            }
        }

        public static int x = 1;
        static public int y = 0;
        static void PrintFiles(FileInfo[] infofiles)
        {
            foreach (FileInfo name in infofiles)
            {
                y = x+1;
                string n = $"{new string('-', y)}{name}";
                Console.WriteLine(n);
                Write(n);
            }
        }
        static void Method(DirectoryInfo[] info)
        {
            foreach (DirectoryInfo dir in info)
            {
                string stroka = $"{new string('-', x)}{dir}";
                Write(stroka);
                Console.WriteLine(stroka);
                if (dir.GetDirectories() != null)
                {
                    if (dir.GetFiles()!=null)
                    {
                        PrintFiles(dir.GetFiles());
                    }
                    x++;
                    Method(dir.GetDirectories());
                }
                x--;
            }
        }

        static void Main(string[] args)
        {
            string waytodir = @"C:\Users\Domnich\Desktop\OOPGame-master";
            var directory = new DirectoryInfo(waytodir);
            Write(directory.Name);
            DirectoryInfo[] dir = directory.GetDirectories();
            Console.WriteLine(directory.Name);
            Method(dir);

            Console.ReadKey();
                     
        }
    }
}
