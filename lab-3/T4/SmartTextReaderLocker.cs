using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace T4
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private Regex _restrictedFilesPattern;
        public SmartTextReaderLocker(string filePath, string restrictedFilesPattern) : base(filePath)
        {
            _restrictedFilesPattern = new Regex(restrictedFilesPattern);
        }
        public new char[][] ReadText()
        {
            if (_restrictedFilesPattern.IsMatch(FilePath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }

            return base.ReadText();
        }
    }
}