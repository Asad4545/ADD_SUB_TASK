using System;
using System.Collections.Generic;
using System.Text;

namespace ADD_SUB_OVERLOADING
{
    public class ADD
    {
        public void add(float x, float y)
        {
            float sum;
            sum = x + y;
            Console.WriteLine("Sum of these numbers is: " + sum);
        }

        public void add(float x, float y, float z)
        {
            float sum;
            sum = x + y+z;
            Console.WriteLine("Sum of these numbers is: "+sum);
        }

        public void add(float x, float y, float z, float a)
        {
            float sum;
            sum = x + y + z + a;
            Console.WriteLine("Sum of these numbers is: "+sum);
        }

        
    }
}
