using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_project
{
    public class TimeBasedActivity
    {
        private double time;
        private double burning_calories;
        static double coefficient_of_treadmill = 0.32;
        public double Treadmill(double time)
        {
            burning_calories = time * coefficient_of_treadmill;
            
            return burning_calories;
        }



        public void setTime(double time)
        {
            this.time = time;
        }
        public double getTime()
        {
            return this.time;
        }

        public void setBurning_calories(double burning_calories)
        {
                this.burning_calories= burning_calories;
        }
        public double getBurning_calories()
        {
                return this.burning_calories;
        }
    }
}
