using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace ECSTechTest
{
    public static class ArrayChallenge
    {
        public static int GetMiddleIndex(int[] elements)
        {
            int EndIndex = (elements.Length - 1);
            int SumRight = 0;
            int StartIndex = 0;
            int SumLeft = 0;
            while (true)
            {
                if ((SumLeft > SumRight))
                {
                    SumRight = (SumRight + elements[EndIndex--]);
                }
                else
                {
                    SumLeft = (SumLeft + elements[StartIndex++]);
                }

                Console.WriteLine(("StartIndex: " + (StartIndex + (" Endindex: " + (EndIndex + (" SumLeft: " + (SumLeft + (" SumRight: " + SumRight))))))));

                if ((SumLeft == SumRight))
                {
                    break;
                }
            }
            return EndIndex;
        }

        public static void Main(String[] args)
        {
            int[] firstarray = new int[] { 23, 50, 63, 90, 10, 30, 155, 23, 18 };
            int midFirstArrayVal = GetMiddleIndex(firstarray);
            Console.WriteLine(("Mid index: " + (midFirstArrayVal + (" Value: " + firstarray[midFirstArrayVal]))));

            int[] secondarray = new int[] { 133, 60, 23, 92, 6, 7, 168, 16, 19 };
            int midSecondArrayVal = GetMiddleIndex(secondarray);
            Console.WriteLine(("Mid index: " + (midSecondArrayVal + (" Value: " + secondarray[midSecondArrayVal]))));

            int[] thirdarray = new int[] { 30, 43, 29, 10, 50, 40, 99, 51, 12 };
            int midThirdArrayVal = GetMiddleIndex(thirdarray);
            Console.WriteLine(("Mid index: " + (midThirdArrayVal + (" Value: " + thirdarray[midThirdArrayVal]))));
            Console.ReadLine();
        }
    }
}

