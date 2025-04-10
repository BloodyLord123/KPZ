using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T4
{
    public class SmartTextChecker : SmartTextReader
    {
        public SmartTextChecker(string filePath) : base(filePath) { }

        public new char[][] ReadText()
        {
            Console.WriteLine($"Opening file: {FilePath}");
            char[][] textArray = base.ReadText();
            int lineCount = textArray.Length;
            int charCount = 0;
            foreach (char[] line in textArray)
            {
                charCount += line.Length;
            }
            Console.WriteLine($"File successfully read. Total lines: {lineCount}, Total characters: {charCount}");
            Console.WriteLine("File closed.");

            return textArray;
        }
    }
}