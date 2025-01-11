using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpnewfeatures
{
    internal static class ExtensionMethods
    {
        public static int square(this int x)
        {
            return x * x;
        }
        public static bool IsEven(this int x)
        {
            return x % 2 == 0?true:false;
        }
        public static bool IsNull(this object obj)
        {
            return obj == null ? false:true;
        }
        public static bool IsPalindrome(this object obj)
        {
            string obj1= obj.ToString();
            obj1 = obj1.Reverse().ToString();
            if(obj1 == obj.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
