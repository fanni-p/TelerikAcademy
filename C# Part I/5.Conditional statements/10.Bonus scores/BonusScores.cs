using System;

namespace _10.Bonus_scores
{
    class BonusScores
    {
        static void Main()
        {
            Console.Write("Enter a score between [1-9]: ");
            int score;
            bool parseSuccess = int.TryParse(Console.ReadLine(), out score);
            if (parseSuccess == true && score > 0)
            {
                switch (score)
                {
                    case 1:
                    case 2:
                    case 3:
                        score = score * 10;
                        Console.WriteLine("Score with bonus:{0}", score);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        score = score * 100;
                        Console.WriteLine("Score with bonus:{0}", score);
                        break;
                    case 7:
                    case 8:
                    case 9:
                        score = score * 1000;
                        Console.WriteLine("Score with bonus:{0}", score);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}
