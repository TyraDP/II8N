using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace II8N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string1 = "ACT";
            string string2 = "CAT";
            //Trim to get rid of extra space
            char[] string1_arr = string1.ToCharArray();



            int numb = 3;
            Console.WriteLine("Number is ");
            Console.WriteLine(numb.IsEven() ? "even" : "odd");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-CA");



            Console.WriteLine(Properties.strings.Prompt);
            string name = Console.ReadLine();
            Console.WriteLine(Properties.strings.Greeting + name);

            int x = 2;

            x = x.Add3();

            Console.WriteLine(x);


        }

        //sort the charcater array

    }
}
