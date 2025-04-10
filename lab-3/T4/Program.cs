using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "test.txt";
            File.WriteAllText(filePath, "Hello\nWorld!");
            Console.WriteLine("Using SmartTextChecker:");
            SmartTextChecker checker = new SmartTextChecker(filePath);
            checker.ReadText();
            Console.WriteLine("\nUsing SmartTextReaderLocker:");
            string restrictedPattern = @"^restricted.*\.txt$"; 
            SmartTextReaderLocker locker = new SmartTextReaderLocker(filePath, restrictedPattern);
            locker.ReadText();
            string restrictedFile = "restricted_file.txt";
            File.WriteAllText(restrictedFile, "This is a restricted file.");
            Console.WriteLine("\nAttempting to read restricted file:");
            SmartTextReaderLocker restrictedLocker = new SmartTextReaderLocker(restrictedFile, restrictedPattern);
            restrictedLocker.ReadText();
        }
    }
}
