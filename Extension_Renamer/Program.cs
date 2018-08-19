using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Renamer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Renamer renamer;
                if (args.Length > 2)
                {
                    renamer = new Renamer(args[0], args[1], args[2]);

                }
                else
                {
                    renamer = new Renamer(args[0], args[1]);
                }
                renamer.Rename();
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("To use this programm please input the following Parameters:");
                Console.WriteLine("[currExtension] The file extension you want to be renamed, with dot (e.g. '.png')");
                Console.WriteLine("[newExtension] The new file extension, with dot");
                Console.WriteLine("[filePath] The path to the files to be changed. If empty, the current directory will be used");
                Console.WriteLine("Extension_Renamer.exe currExtension newExtension filePath");

            }

            String Test = Console.ReadLine();
        }
    }
}
