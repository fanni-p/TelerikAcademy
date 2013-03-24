using System;

namespace _1.Ship_Damage
{
    class ShipDamage
    {
        static void Main()
        {
            int Sx1 = int.Parse(Console.ReadLine());
            int Sy1 = int.Parse(Console.ReadLine());
            int Sx2 = int.Parse(Console.ReadLine());
            int Sy2 = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int Cx1 = int.Parse(Console.ReadLine());
            int Cy1 = int.Parse(Console.ReadLine());
            int Cx2 = int.Parse(Console.ReadLine());
            int Cy2 = int.Parse(Console.ReadLine());
            int Cx3 = int.Parse(Console.ReadLine());
            int Cy3 = int.Parse(Console.ReadLine());
            int countDamage = 0;
            int MinX = Math.Min(Sx1, Sx2);
            int MaxX = Math.Max(Sx1, Sx2);
            int MinY = Math.Min(Sy1, Sy2);
            int MaxY = Math.Max(Sy1, Sy2);

            Cy1 = H + (H - Cy1);
            Cy2 = H + (H - Cy2);
            Cy3 = H + (H - Cy3);

            if ((MaxY == Cy1 || MinY == Cy1) && ((MaxX > Cx1) && (Cx1 > MinX)) ||
                (MaxX == Cx1 || MinX == Cx1) && ((MaxY > Cy1) && (Cy1 > MinY)))
            {
                countDamage += 50;
            }
            if ((MaxY == Cy2 || MinY == Cy2) && ((MaxX > Cx2) && (Cx2 > MinX)) ||
                (MaxX == Cx2 || MinX == Cx2) && ((MaxY > Cy2) && (Cy2 > MinY)))
            {
                countDamage += 50;
            }
            if ((MaxY == Cy3 || MinY == Cy3) && ((MaxX > Cx3) && (Cx3 > MinX)) ||
                (MaxX == Cx3 || MinX == Cx3) && ((MaxY > Cy3) && (Cy3 > MinY)))
            {
                countDamage += 50;
            }

            if ((MaxX == Cx1 || MinX == Cx1) && (MaxY == Cy1 || MinY == Cy1))
            {
                countDamage += 25;
            }
            if ((MaxX == Cx2 || MinX == Cx2) && (MaxY == Cy2 || MinY == Cy2))
            {
                countDamage += 25;
            }
            if ((MaxX == Cx3 || MinX == Cx3) && (MaxY == Cy3 || MinY == Cy3))
            {
                countDamage += 25;
            }

            if ((MaxY > Cy1) && (Cy1 > MinY) && (MaxX > Cx1) && (Cx1 > MinX))
            {
                countDamage += 100;
            }
            if ((MaxY > Cy2) && (Cy2 > MinY) && (MaxX > Cx2) && (Cx2 > MinX))
            {
                countDamage += 100;
            }
            if ((MaxY > Cy3) && (Cy3 > MinY) && (MaxX > Cx3) && (Cx3 > MinX))
            {
                countDamage += 100;
            }
            Console.WriteLine(countDamage + "%");
        }
    }
}
