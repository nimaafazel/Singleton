using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class MySingleton
    {
        // create a static property of a class to make it live the entire life of the program.
        private static MySingleton single;

        // make the constructor private so nobody can instantiate this class.
        private MySingleton()
        {
        }

        // create a static accesor method, that will return the instance
        public static MySingleton getSingle()
        {
            // create the instance, only if it is the first time that is called
            if (single == null)
                single = new MySingleton();

            // return the same instance always.
            return single;
        }




        /// <summary>
        /// This is just an example method that one can call, once we have the instance
        /// </summary>
        /// <param name="something"></param>
        public void printSomething(string something)
        {
            Console.WriteLine(something);
        }
    }
}
