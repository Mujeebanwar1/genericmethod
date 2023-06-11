using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericmethod
{
    internal class maximumstringvalue
    {
        public string StringCompare(string frist, string second, string third)
        {
            if (frist.CompareTo(second) > 0 && frist.CompareTo(third) > 0)
            {
                return frist;
            }
            else if (second.CompareTo(frist) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(frist) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            return "0";
            
        }
        
    }
}
