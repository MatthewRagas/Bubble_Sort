using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static int loops = 0;
        static int swapss = 0;
        static void Main(string[] args)
        {            
            int[] numList = {14,65,63,1,54,89,84,9,98,
                57,71,18,21,84,69,28,11,83,13,42,64,58,
                78,82,13,9,96,14,39,89,40,32,51,85,48,
                40,23,15,94,93,35,81,1,9,43,39,15,17,97,52};
            Console.WriteLine("This array is not sorted!");
            for(int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine(numList[i]);
            }
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("This array is now sorted!");

            //BubbleSort(numList);
            //OptomizedBubbleSort(numList);
            CocktailShakerSort(numList);

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
        public static void BubbleSort(int[] numList)
        {
            bool sorted = false;           

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
            
        }

        public static void OptomizedBubbleSort(int[] numList)
        {
            bool sorted = false;
            int o = numList.Length - 1;
            while (!sorted)
            {
                sorted = true;
                int n;                
                for (int i = 0; i < o; i++)
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
                o--;
            }

        }
        public static void CocktailShakerSort(int[] numList)
        {
            bool sorted = false;
            int end = numList.Length - 1;
            int start = 0;
            int n;
            while (!sorted)
            {
                sorted = true;
                for (int i = start; i < end; i++)
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
                end--;               
                for(int i = end; i > start; i--)
                {
                    if(numList[i - 1] > numList[i])
                    {
                        n = numList[i - 1];
                        numList[i - 1] = numList[i];
                        numList[i] = n;
                        sorted = false;
                        swapss++;
                    }                    
                    loops++;
                }            
                start++;
            }
        }
        public static void QuickSort(int[] numList)
        {

        }
    }
}
