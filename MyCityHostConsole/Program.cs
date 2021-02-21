using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MyCityHostConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost sh1 = new ServiceHost(typeof(MyCityLibrary.StoreService));

            ServiceHost sh2 = new ServiceHost(typeof(MyCityLibrary.UserService));

            sh1.Open();
            sh2.Open();

            Console.WriteLine("Published");
            Console.ReadLine();

            sh1.Close();
            sh2.Close();

        }
    }
}
