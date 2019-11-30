using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
      
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client sclient = new ServiceReference1.Service1Client();
           int res= sclient.Sum(4,6);
            Console.WriteLine("Sum =" + res);
            Console.ReadKey();

        }
    }
}
