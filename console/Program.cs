using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            Console.WriteLine(Assembly.GetCallingAssembly().FullName);
            Console.ReadKey();
        }
    }
}
