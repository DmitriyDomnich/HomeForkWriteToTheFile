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
        static void Print2(DirectoryInfo[] info, int sub)
        {
            int i = 0;
            foreach (DirectoryInfo dir in info)
            {
                Console.WriteLine($"{new string('-', sub)}{info[i].Name}");
                i++;
            }
        }
       public static int x = 1;

        static void Method(DirectoryInfo[] info)
        {           
            foreach (DirectoryInfo dir in info)
            {
                Console.WriteLine($"{new string('-', x)}{dir}");
                if (dir.GetDirectories() != null)
                {
                    x++;
                    Method(dir.GetDirectories());
                }
                x --;
            }
        }

        static void Main(string[] args)
        {
            string waytodir = @"C:\Users\Domnich\Desktop\OOPGame-master";
            var directory = new DirectoryInfo(waytodir);

            DirectoryInfo[] dir = directory.GetDirectories();
            Method(dir);

        }
    }
}



