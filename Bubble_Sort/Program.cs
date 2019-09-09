using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] numList = { 45, 6, 12, 51, 4, 23, 31 };
            Console.WriteLine("This array is not sorted!");
            for(int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine(numList[i]);
            }
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("This array is now sorted!");

            //bool sorted = false;

            //while(!sorted)
            //{
            //    sorted = true;
            //    int n;
            //    for(int i = 0; i < numList.Length - 1; i++)
            //    {
            //        if (numList[i] > numList[i + 1])
            //        {
            //            n = numList[i];
            //            numList[i] = numList[i + 1];
            //            numList[i + 1] = n;
            //            sorted = false;
            //        }
            //        else
            //            continue;
            //    }
            //}
            //for (int i = 0; i < numList.Length; i++)
            //{
            //    Console.WriteLine(numList[i]);
            //}
            //Console.ReadKey();
            //return;
            for(int i = 0; i < numList.Length; i++)
            {
                for(int n = 0; n < numList.Length; n++)
                {
                    int p;
                    if (numList[i] > numList[n])
                    {
                        p = numList[n];
                        numList[n] = numList[i];
                        numList[i] = p;
                    }
                    else
                        continue;
                }
            }
            for (int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine(numList[i]);
            }
            Console.ReadKey();               
        }
    }
}
