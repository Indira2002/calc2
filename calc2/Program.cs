using System;
using System.Collections.Generic;
using System.Collections;
namespace calc2
{
    class Program
    {
        class calc2
        {
            static int Sum()
            {
                int x = 2;
                int y = 3;
                int z = x + y;
                return z;
            }
            static int Razn()
            {
                int x = 2;
                int y = 3;
                int z = x - y;
                return z;
            }
            static int Proizv()
            {
                int x = 3;
                int y = 2;
                int z = x * y;
                return z;
            }
            static double Chastnoe()
            {
                double x = 3;
                double y = 2;
                double z = x / y;
                return z;
            }
            static double Stepen()
            {
                double x = 3;
                double y = 2;
                double z = Math.Pow(x, y);
                return z;
            }
            static double Kvadr()
            {
                double x = 3;
                double z = Math.Sqrt(x);
                return z;
            }

        } 
           
            static void Main(string[] args)
        {
            List<calc2> list = new List<calc2>();
            
        }
    }
}
