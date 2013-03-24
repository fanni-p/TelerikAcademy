using System;

namespace _2.Miss_Cat
{
    class MissCat
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] cat = new int[11];
            for (int i = 1; i <= n; i++)
            {
                byte vote = byte.Parse(Console.ReadLine());
                cat[vote]++;
            }
            int bestCat = 0;
            int bestVote = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (cat[i] > bestVote)
                {
                    bestCat = i;
                    bestVote = cat[i];
                }
            }
            Console.WriteLine(bestCat);
        }
    }
}
