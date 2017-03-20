using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise1
{
    class Program
    {
        public static int[] values1 = { 1, 2, 3, 9 };
        public static int[] values2 = { 1, 2, 4, 4 };
        static void Main(string[] args)
        {
            if (HasSumOfPairs(values1, 8))
            {
                Console.WriteLine("1st  test FOUND");
            }
            else
                Console.WriteLine("1st  test NOTFOUND");

            if (HasSumOfPairs(values2, 8))
            {
                Console.WriteLine("2nd  test FOUND");
            }
            else
                Console.WriteLine("2nd  test NOTFOUND");

            Console.ReadLine();
        }

        public static bool HasSumOfPairs(int[] values, int sum)
        {
            int low = 0;
            int high = values.Length -1; 

            int res = 0;
            
            while (low < high)
            {

                if (low < 0 || high < 0)
                {
                    Console.WriteLine("OUT of Bounds");
                    return false;
                }


                res = values[low] + values[high];
                if (res == sum)
                {
                    return true;
                }
                else
                {
                    if (res > sum)
                    {
                        high--;
                    }
                    else if (res < sum)
                    {
                        low++;
                    }
                    
                }    
            }

            return true;

        }
    }
}
