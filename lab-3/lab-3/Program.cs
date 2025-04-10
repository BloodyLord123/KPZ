using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Logger consoleLogger = new Logger();
            consoleLogger.Log("Запуск програми");
            consoleLogger.Warn("Виявлено вірус");
            consoleLogger.Error("Сталася помилка!");
            FileWriter writer = new FileWriter("log.txt");
            ILogger fileLogger = new FileLogger(writer);
            fileLogger.Log("Запис у файл: програма запущена");
            fileLogger.Warn("Запис у файл: попередження");
            fileLogger.Error("Запис у файл: помилка");
            consoleLogger.Log("Роботу завершено");
        }
    }
}
