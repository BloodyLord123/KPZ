using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Authenticator auth1 = Authenticator.GetInstance();
            Authenticator auth2 = Authenticator.GetInstance();
            Console.WriteLine(auth1 == auth2? "\nAuthenticator працює, обидва екземпляри однакові.\n": "\n Authenticator не працює, екземпляри різні.\n");
            auth1.Authenticate("Admin");
            auth2.Authenticate("User");
            Console.ReadKey();
        }
    }
}
