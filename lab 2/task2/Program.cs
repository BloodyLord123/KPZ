using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Factories;
using task2.Interfaces;

namespace task2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ITechFactory iproneFactory = new IProneFactory();
            IDevice iproneLaptop = iproneFactory.CreateLaptop();
            IDevice iproneNetbook = iproneFactory.CreateNetbook();
            IDevice iproneEBook = iproneFactory.CreateEBook();
            IDevice iproneSmartphone = iproneFactory.CreateSmartphone();

            iproneLaptop.ShowInfo();
            iproneNetbook.ShowInfo();
            iproneEBook.ShowInfo();
            iproneSmartphone.ShowInfo();
            Console.WriteLine();

            ITechFactory kiaomiFactory = new KiaomiFactory();
            IDevice kiaomiLaptop = kiaomiFactory.CreateLaptop();
            IDevice kiaomiNetbook = kiaomiFactory.CreateNetbook();
            IDevice kiaomiEBook = kiaomiFactory.CreateEBook();
            IDevice kiaomiSmartphone = kiaomiFactory.CreateSmartphone();

            kiaomiLaptop.ShowInfo();
            kiaomiNetbook.ShowInfo();
            kiaomiEBook.ShowInfo();
            kiaomiSmartphone.ShowInfo();
            Console.WriteLine();

            ITechFactory balaxyFactory = new BalaxyFactory();
            IDevice balaxyLaptop = balaxyFactory.CreateLaptop();
            IDevice balaxyNetbook = balaxyFactory.CreateNetbook();
            IDevice balaxyEBook = balaxyFactory.CreateEBook();
            IDevice balaxySmartphone = balaxyFactory.CreateSmartphone();

            balaxyLaptop.ShowInfo();
            balaxyNetbook.ShowInfo();
            balaxyEBook.ShowInfo();
            balaxySmartphone.ShowInfo();
        }

    }
}
