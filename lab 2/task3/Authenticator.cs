using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Authenticator
    {
        private static Authenticator _instance;
        private static readonly object _lock = new object();
        private readonly Guid _id; 
        private Authenticator()
        {
            _id = Guid.NewGuid();
            Console.WriteLine($"Створено новий екземпляр Authenticator з ID: {_id}");
        }
        public static Authenticator GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock) 
                {
                    if (_instance == null)
                    {
                        _instance = new Authenticator();
                    }
                }
            }
            return _instance;
        }
        public void Authenticate(string username)
        {
            Console.WriteLine($"Користувач '{username}' автентифікований. (ID: {_id})");
        }
    }
}

