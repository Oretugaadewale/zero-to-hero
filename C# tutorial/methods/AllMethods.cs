using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__tutorial.methods
{
    internal class AllMethods
    {
       public void Method (int Target)
        {
            int Start = 0;

            while (Start <= Target)
            {
               Console.WriteLine(Start); 
                Start = Start + 2;
            }

        }

        public int Add(int fn, int ln)
        {
            return fn + ln;
        }
    }
}
