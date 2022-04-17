using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Console.Read();

            int[] set = new int[N];
            for (int i = 0; i < N; i++)
            {
                set[i] = Convert.ToInt32(Console.Read());
            }

            ////string newe = "abcabcbb";

            ////Console.WriteLine(newe);

            ////char[] chars = newe.ToCharArray();
            ////char[] set = null; int x = 0;
            ////for (int i = 0; i < chars.Length; i++)
            ////{

            ////    for (int j = i + 1; j < chars.Length; j++)
            ////    {

            ////        if (chars[i] != chars[j])
            ////        {
            ////            x = x + 1;

            ////        }
            ////        else
            ////            x = 0;
            ////    }
            ////}


            //int flag = 0; int ans = -1;
            //int A = 1065024;
            //int[] B = new int [2];
            //int len = B.Length;
            //int x = Convert.ToInt32( B[i]);
            //Console.WriteLine(newe);

            //int end = A;
            //int mid;
            //while (i <= end && flag == 0)
            //{
            //    mid = (i + end) / 2;

            //    if (mid * mid == A)
            //    {
            //        flag = 1;
            //        ans = mid;
            //        break;
            //    }

            //    if (mid * mid > A)
            //        end = (mid - 1);
            //    if (mid * mid < A)
            //        i = mid + 1;
            //}
            //if (ans > 0)
            //    Console.WriteLine(ans);
            //else
            //    Console.WriteLine(-1);
        }
    }
}
