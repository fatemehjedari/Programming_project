using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_project
{
    public class User
    {
        public string name;
        public double weight;
        public double height;

      
        public User(string name, double weight, double height)
        {

            this.name = name;
            this.weight = weight;
            this.height = height;

            Console.WriteLine("User class' trial");

        }

    
        // database

    
        

        public void setName(string name)
        {
            this.name = name;
        }
        public void setWeight(double weight) {
            this.weight = weight;}
        public void setHeight(double height)
        {
            this.height = height;
        }

        public string getName()
        {
            return this.name;
        }
        public double getWeight()
        {
            return this.weight;
        }
        public double getHeight()
        {
            return this.height;
        }



    }
}
