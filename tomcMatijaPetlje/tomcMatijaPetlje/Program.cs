using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPetlje
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Unesi jednu rijec: ");
            text = Console.ReadLine();
            for(int i=0; i<text.Length; i++)
            {
                Console.WriteLine(text.Substring(0, i+1));
            }
            Console.ReadKey();
        }
    }
}
