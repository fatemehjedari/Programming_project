using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_project
{
     public class Goals
    {
        private int calories;
        private float kilos;
        private int push_up;
        private int dumble; 


        public Goals(int calories, float kilos) // Interface about calories and kilos
        {
            this.calories = calories;
            this.kilos = kilos;
        }
        public Goals(int push_up, int dumble) // overloading with different goals.
        {
            this.push_up = push_up;
            this.dumble = dumble;

        }

        // database
        public void setCalories(int calories)
        {
            this.calories = calories;
        }
        public int getCalories()
        {
            return this.calories;
        }
        
        public void setKilos(float kilos)
        {
            this.kilos = kilos;
        }
        public float getKilos()
        {
            return this.kilos;
        }
        public void setPush_up(int push_up)
        {
            this.push_up = push_up;
        }
        public int getPush_up()
        {
            return this.push_up;
        }
        public void setDumble(int dumble)
        {
            this.dumble = dumble;
        }    
        public int getDumble()
        {
            return this.dumble;
        }
    }

}
