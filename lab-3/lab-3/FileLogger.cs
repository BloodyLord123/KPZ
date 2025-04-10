using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    public class FileLogger : ILogger
    {
        private FileWriter fileWriter;

        public FileLogger(FileWriter writer)
        {
            fileWriter = writer;
        }
        public void Log(string message)
        {
            fileWriter.WriteLine($"[INFO]: {message}");
        }

        public void Error(string message)
        {
            fileWriter.WriteLine($"[ERROR]: {message}");
        }

        public void Warn(string message)
        {
            fileWriter.WriteLine($"[WARN]: {message}");
        }
    }
}
