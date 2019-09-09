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
            int[] numList = {14,65,63,1,54,89,84,9,98,
                57,71,18,21,84,69,28,11,83,13,42,64,58,
                78,82,13,9,96,14,39,89,40,32,51,85,48,
                40,23,15,94,93};
            Console.WriteLine("This array is not sorted!");
            for(int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine(numList[i]);
            }
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("This array is now sorted!");

            bool sorted = false;
            int loops = 0;
            int swapss = 0;

            while (!sorted)
            {
                sorted = true;
                int n;
                for (int i = 0; i < numList.Length - 1; i++)
                {
                    if (numList[i] > numList[i + 1])
                    {
                        n = numList[i];
                        numList[i] = numList[i + 1];
                        numList[i + 1] = n;
                        sorted = false;
                        swapss++;                       
                    }
                    loops++;

                }
                
            }
            for (int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine(numList[i]);
            }
            Console.WriteLine("Loops: " + loops);
            Console.WriteLine("Swaps: " + swapss);
            Console.ReadKey();
            return;
            int loopOne = 0;
            int loopTwo = 0;
            int swaps = 0;
            for(int i = 0; i < numList.Length; i++)
            {
                for(int n = 0; n < numList.Length; n++)
                {
                    int p;
                    if (numList[i] < numList[n])
                    {
                        p = numList[i];
                        numList[i] = numList[n];
                        numList[n] = p;
                        loopTwo++;
                        swaps++;
                    }
                    else
                    {
                        loopTwo++;
                    }                        
                }
                loopOne++;
            }
            for (int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine(numList[i]);
            }
            Console.WriteLine("Loops in A: " + loopOne);
            Console.WriteLine("Loops in B: " + loopTwo);
            Console.WriteLine("Swaps: " + swaps);
            Console.ReadKey();               
        }
    }
}
