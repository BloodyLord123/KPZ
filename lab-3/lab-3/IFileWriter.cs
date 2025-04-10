using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    public interface IFileWriter
    {
        void Write(string line);
        void WriteLine(string line);
    }
}
