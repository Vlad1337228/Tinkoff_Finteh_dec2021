using System;
using System.Collections.Generic;
using System.Linq;

namespace tibkoff_work
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            var arr = new int[3,3];
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                arr[0,0] = i;
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[0,1] = j;
                    arr[0,2] = N - arr[0,0] - arr[0,1];
                    if(arr[0,2]>=0 && arr[0,2]<=9)
                    {
                        for (int k = 0; k < arr.Length; k++)
                        {
                            arr[1, 0] = k;
                            arr[2, 0] = N - arr[0, 0] - arr[1, 0];
                            if(arr[ 2,0] >= 0 && arr[2,0] <= 9)
                            {
                                for(int g=0;g<arr.Length;g++)
                                {
                                    arr[1, 1] = g;
                                    arr[1, 2] = N - arr[1, 1] - arr[1, 0];
                                    if (arr[1, 2] >= 0 && arr[1,2] <= 9)
                                    {
                                        arr[2, 1] = N - arr[0, 1] - arr[1, 1];
                                        if(arr[2, 1]>=0 && arr[2, 1]<=9)
                                        {
                                            arr[2, 2] = N - arr[2, 1] - arr[2, 0];
                                            if(arr[2,2]>=0 && arr[2,2]<=9 && (arr[0,2] + arr[1,2] + arr[2,2])==N)
                                            {
                                                count++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }

        
    }
}
