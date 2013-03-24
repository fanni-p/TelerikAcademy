using System;

namespace _1.Fighter_Attack
{
    class FighterAttack
    {
        static void Main()
        {
            int px1 = int.Parse(Console.ReadLine());
            int py1 = int.Parse(Console.ReadLine());
            int px2 = int.Parse(Console.ReadLine());
            int py2 = int.Parse(Console.ReadLine());
            int fx = int.Parse(Console.ReadLine());
            int fy = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int hitX = fx + d;
            int hit1 = fx + d + 1;
            int maxX = Math.Max(px1, px2);
            int minX = Math.Min(px1, px2);
            int maxY = Math.Max(py1, py2);
            int minY = Math.Min(py1, py2);
            int sum = 0;
            if (minX <= hitX && hitX <= maxX && minY <= fy && fy <= maxY)
            {
                sum += 100;
            }
            if (minX <= hit1 && hit1 <= maxX && minY <= fy && fy <= maxY)
            {
                sum += 75;
            }
            if (minX <= hitX && hitX <= maxX && minY <= (fy + 1) && (fy + 1) <= maxY)
            {
                sum += 50;
            }
            if (minX <= hitX && hitX <= maxX && minY <= (fy - 1) && (fy - 1) <= maxY)
            {
                sum += 50;
            }
            Console.WriteLine(sum + "%");
        }
    }
}
