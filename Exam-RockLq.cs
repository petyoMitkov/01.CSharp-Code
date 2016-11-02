using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RockLq
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            int width = inputNum * 3;
            int height = inputNum * 2;

            Console.WriteLine("{0}{1}{0}", new string('.', inputNum), new string('*', inputNum));

            int dots = inputNum - 2;
            int midelDots = inputNum + 2;

            for (int i = 0; i < inputNum/2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', midelDots));
                dots -= 2;
                midelDots += 4;
            }

            dots = inputNum - 2;
            midelDots = inputNum;
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', dots), new string('.', midelDots));
            

            dots = inputNum - 4;
            midelDots = inputNum;
            int oneDots = 1;

            //int checkerLength = 1;
            //if (inputNum > 19 )
            //{
            //    checkerLength = 2;
            //}
            //if (inputNum > 29)
            //{
            //    checkerLength = 3;
            //}

            for (int i = 0; i < inputNum/2 - 1; i++)
            {
                Console.WriteLine("*{0}*{2}*{1}*{2}*{0}*", new string('.', dots),
                    new string('.', midelDots),new string('.', oneDots));
                dots -= 2;
                oneDots += 2;
            }

            dots = inputNum - 1;
            midelDots = inputNum;
            for (int i = 0; i < inputNum - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', midelDots));
                dots--;
                midelDots += 2;
            }
            Console.WriteLine("{0}", new string('*', inputNum * 3));
            
            
        }
    }
}
