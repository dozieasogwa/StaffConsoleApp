using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConsoleApp
{
 public class MyClass
    {
        //Non static members
        public string message = "Hello World";
        public string Name { set; get; }
        public void DisplayName()
        {
            Console.WriteLine("Name = {0}", Name);
        }

        //Static members
        public static string greetings = "Good morning";
        public static int Age { get; set; }
        public static void DisplayAge()
        {
            Console.WriteLine("Age = {0}", Age);
        }

    }
}
