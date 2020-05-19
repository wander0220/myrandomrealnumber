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
            Random random = new Random();
            int num = random.Next(0, 1000);

            //Console.WriteLine(num);

            while (true)
            {
                Console.Write("숫자를 입력해주세요(0~1000) : ");
                string input = Console.ReadLine();
                int num02 = Convert.ToInt32(input);

                if (num > num02)
                {
                    Console.WriteLine(num02 + "보다 큰 숫자입니다");
                }
                else if (num < num02)
                {
                    Console.WriteLine(num02 + "보다 작은 숫자입니다");
                }
                else
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }

                Console.WriteLine();

            }
        }
    }
}
