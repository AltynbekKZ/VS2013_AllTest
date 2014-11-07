using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestAllConsoleAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "awdaw OR clkmekcnes OR acnlen OR slmclske OR";
            str = str.Substring(0, str.LastIndexOf("OR"));
            Console.WriteLine(str);
            Console.ReadKey();
        }
        
    }
}
