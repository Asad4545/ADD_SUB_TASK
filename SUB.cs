using System;
using System.Collections.Generic;
using System.Text;

namespace ADD_SUB_OVERLOADING
{
    public class SUB
    {
        public void sub(float x, float y)
        {
            float subtract;
            subtract = x - y;
            Console.WriteLine("Subtraction of these numbers is: " + subtract);
        }

        public void sub(float x, float y, float z)
        {
            float subtract;
            subtract = x - y - z;
            Console.WriteLine("Subtraction of these numbers is: " + subtract);
        }

        public void sub(float x, float y, float z, float a)
        {
            float subtract;
            subtract = x - y - z - a;
            Console.WriteLine("Subtraction of these numbers is: " + subtract);
        }

    }
}
