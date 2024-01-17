using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.IO.Interfaces;

namespace MilitaryElite.IO.Models
{
    internal class FileReader:IReader
    {
        private StreamReader reader;
        // Initialize the StreamReader in the constructor

        public FileReader(string path)
        {
           
            if (File.Exists(path))
            {
                reader = new StreamReader(path);
            }
            else
            {
                throw new FileNotFoundException("File not found", path);
            }
        }
        public string ReadLine()
        {
            return reader.ReadLine();
        }
        public void Close()
        {
            reader?.Close();
        }

    }
}
