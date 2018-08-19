using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Renamer
{

    class Renamer
    {
        private String _currExtension;
        private String _newExtension;
        private String _filePath;

        public Renamer (String currExtension, String newExtension, String filePath){
            _currExtension = currExtension;
            _newExtension = newExtension;
            _filePath = filePath;
        }

        public Renamer(String currExtension, String newExtension)
        {
            _currExtension = currExtension;
            _newExtension = newExtension;
            _filePath = Directory.GetCurrentDirectory();
        }

        public void Rename()
        {
            foreach (string fileName in Directory.GetFiles(_filePath))
            {
                //Console.WriteLine(fileName);
                //Console.WriteLine(Path.GetExtension(fileName));
                if (Path.GetExtension(fileName).Equals(_currExtension))
                {
                    String newFileName = _filePath + "\\" + Path.GetFileNameWithoutExtension(fileName) + _newExtension;
                    System.IO.File.Move(fileName, newFileName);
                    Console.WriteLine(fileName + " renamed to " + newFileName);
                }
            }
        }
    }
}
