using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {

        public static void Name()
        {
            Console.WriteLine("My Name is Fabian");
        }

        public static string Secret()
        {
            string secretkey = "ITS SO SECRET";
            return secretkey; 

        }


        public static int Test(int a ,int b)
        {
            
            return a + b;

        }
        static void Main(string[] args)
        {
            /* Calling out the function */
            Name();
            Name();
            Name();

            /* return value of the function and inputs result */
            string key = Secret();
            Console.WriteLine(key);

            

            /* Returns the value of the function with the arguments */
            int result = Test(5,6);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
