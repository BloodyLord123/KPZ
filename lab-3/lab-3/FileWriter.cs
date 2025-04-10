using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    public class FileWriter : IFileWriter
    {
        private string filePath;

        public FileWriter(string path)
        {
            filePath = path;
        }

        public void Write(string text)
        {
            Console.Write($"[WRITE to {filePath}]: {text}");
        }

        public void WriteLine(string text)
        {
            Console.WriteLine($"[WRITE LINE to {filePath}]: {text}");
        }
    }
}
