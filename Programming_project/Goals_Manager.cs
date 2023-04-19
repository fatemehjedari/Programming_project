using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_project
{
    internal class Goals_Manager
    {

        List<Goals> goals = new List<Goals>();

        public void AddGoals(Goals goal)
        {
            Console.WriteLine("Goals has been registered");
            goals.Add(goal);
        }

        public List<Goals> showGoals()
        {
            return goals;
        }
        // Arraylist will be added to Database in the class


    }
}
