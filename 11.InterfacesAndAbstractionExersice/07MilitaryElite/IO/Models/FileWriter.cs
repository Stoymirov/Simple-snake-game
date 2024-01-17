using System;
using System.IO;
using MilitaryElite.IO.Interfaces;

namespace MilitaryElite.IO.Models
{
    public class FileWriter : IWriter, IDisposable
    {
        private StreamWriter sw;

        public FileWriter(string path)
        {
            sw = new StreamWriter(path);
        }

        public void WriteLine(string line)
        {
            sw.WriteLine(line);
        }

        public void Dispose()
        {
            // Close and dispose of the StreamWriter when the object is disposed
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                sw?.Close();
                sw?.Dispose();
            }
        }

        ~FileWriter()
        {
            Dispose(false);
        }
    }
}