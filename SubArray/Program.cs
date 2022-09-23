using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArray
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int[]arr= new[] { 12, 4, 2, 10, 5, 1 };
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum = arr[i];
                for(int j = 0; j < arr.Length; j++)
                {
                    sum = sum + arr[j];
                    if(sum==a)
                    {
                        for(int k=i;k<=j;k++)
                        {
                            Console.WriteLine(arr[k]);
                        }
                        Console.WriteLine();
                    }
                    else if(sum>a)
                    {
                        break;
                    }
                }
            }
        }
    }
}
