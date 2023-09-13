using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is now the normal while loop");
            int index = -6;

            while (index <= 5) 
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine("This is now the do while loop");
            int index2 = -6;
            do
            { 
                Console.WriteLine(index2); 
                index2++;

            }
            while (index2 <= 5);

            //freeze console
            Console.Read();

        }
    }
}
