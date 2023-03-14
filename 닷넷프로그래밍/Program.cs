using System;
using System.Collections.Generic;
using System.Linq;

namespace 닷넷프로그래밍
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var ansWord = "";


            List<int> ansCount = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (!(ansWord.Contains(word[i])))
                {
                    ansWord = ansWord + word[i];
                    ansCount.Add(1);
                }
                else
                {
                    ansCount[ansWord.IndexOf(word[i])] += 1;
                }
            }

            var ansMax = ansCount.Max();     // count중 가장 높은 수
            var maxCount = ansCount.IndexOf(ansMax); // 가장 높은 수의 index
            Console.WriteLine(ansMax);
            Console.WriteLine(ansWord[maxCount]);
        }
    }
}