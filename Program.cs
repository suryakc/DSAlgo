using System;
using System.Collections.Generic;

using Algorithmics;
using Algorithmics.Search;

namespace DSAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Fibonacci
            //Console.WriteLine(Fibonacci.RecursiveGet(1));
            //Console.WriteLine(Fibonacci.IterativeGet(1));
            #endregion Fibonacci

            #region Search
            #region BinarySearch
            List<int> haystackSorted = new List<int> () { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 10 };
            //List<int> haystackSorted = new List<int> () { 0, 1, 1, 2 };
            //List<int> haystackUnSorted = new List<int> () { 11, 21, 13, 4, 50, 16, 1, 8, 18, 9, 10 };
            Console.WriteLine(BinarySearch.Find(haystackSorted, 111));
            #endregion BinarySearch
            #endregion Search
        }
    }
}
