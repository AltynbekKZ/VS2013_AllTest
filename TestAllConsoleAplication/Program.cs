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
            string str = "lskfmsfkshef s FSfSF*.docx;";
            string[] list = str.Split(';');

            list = list.Where(s => !string.IsNullOrEmpty(s)).ToArray();


            
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
        
    }
}
