using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace T4
{
    public class SmartTextReader
    {
        public string FilePath { get; }

        public SmartTextReader(string filePath)
        {
            FilePath = filePath;
        }

        public char[][] ReadText()
        {
            string[] lines = File.ReadAllLines(FilePath);
            char[][] textArray = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                char[] lineChars = new char[lines[i].Length];
                for (int j = 0; j < lines[i].Length; j++)
                {
                    lineChars[j] = lines[i][j];
                }
                textArray[i] = lineChars;
            }

            return textArray;
        }
    }
}
