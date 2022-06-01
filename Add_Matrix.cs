using System;
using System.Collections.Generic;

namespace Add_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<List<int>> A = new List<List<int>>() { new List<int>(){1,2,3},
                                    new List<int>(){4,5,6},
                                    new List<int>(){7,8,9},
                                };
            List<List<int>> B = new List<List<int>>() { new List<int>(){6},
                                    new List<int>(){7},
                                    new List<int>(){3},
                                };
            List<List<int>> ans = new List<List<int>>();
           
            for (int i = 0; i < A.Count; i++)
            {
                List<int> temp = new List<int>();
                for (int j = 0; j < A[i].Count; j++)
                {
                    temp.Add ( A[i][j] + B[i][j] );
                }
                ans.Add(temp);
                
            }

        }
    }
}
