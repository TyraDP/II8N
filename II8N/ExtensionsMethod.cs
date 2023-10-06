using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace II8N
{
    internal static class ExtensionsMethod
    {
        //Rules for Extensions menthod
        //1. Method and class have to be static
        //2. use int
        //3. Need to use the "this" keyword
        //


        public static int Add3(this int x)
        {
            return x + 3;
        }

        public static bool IsEven(this int y) 
        {
            //study the out parameter

            return y % 2 == 0;
               
        }

        public static bool IsOdd(this int y)
        {
            return !IsEven(y);
        }
    }
}
