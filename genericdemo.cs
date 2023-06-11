using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace genericmethod
{
    internal class genericdemo
    {
        public static bool Arequal(int value1, int value2)
        {
            return value1 == value2; 
        }
        public static bool stringvalue(string a, string b)
        {
            return a == b;
        }
        public static bool floatvalue(float a, float b)
        {
            return a == b;
        }
        public static bool Arequal<T>(int value1, int value2)
        {
            return value1.Equals(value2);   
        }
    }
}
