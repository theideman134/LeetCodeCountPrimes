using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCountPrimes
{
    public class Solution
    {
        public int CountPrimes(int n)
        {
            if (n == 1)
                return 0;
            if (n == 2)
                return 1;


            var primeList = new List<int>() { 2 };

            for(int i = 3; i <= n;i++)
            {
          

                if (i % 2 == 0)
                    continue;
             
                var isPrime = true;

                foreach (var foundPrime in primeList)
                {
                  
                    if (i % foundPrime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if(isPrime)
                {
                    primeList.Add(i);
                }
            }
            return primeList.Count;
        }
    }
}
