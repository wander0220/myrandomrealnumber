using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for(int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int num = random.Next(0, 100);

                Console.WriteLine(num);
            }
            
            //while (true)
            //{

            //}
        }
    }
}
