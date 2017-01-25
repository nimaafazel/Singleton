using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will not compile because we hid the constructor to avoid direct instantiation... so...
            // MySingleton mySing = new MySingleton();

            // we will use it like this
            MySingleton mySing = MySingleton.getSingle();
            mySing.printSomething("Nima");
        }
    }
}
