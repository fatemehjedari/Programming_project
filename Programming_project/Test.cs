using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_project
{
    class Test
    {
        public static void Main(string[] args)
        {
            string name;
            double weight;
            double height;

            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your weight");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your height");
            height = Convert.ToDouble(Console.ReadLine());  

          User user1 = new User(name, weight, height);
            

            
            

        }
    }
}
