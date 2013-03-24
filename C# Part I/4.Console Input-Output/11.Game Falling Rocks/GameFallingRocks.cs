using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11.Game_Falling_Rocks
{
    struct Symbol
    {
        public int x;
        public int y;
        public string c;
        public ConsoleColor color;
    }

    class GameFallingRocks
    {
        static void PrintOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }
        static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }
        static void Main(string[] args)
        {
            int livesCount = 5;
            Console.BufferHeight = Console.WindowHeight = 20;
            Console.BufferWidth = Console.WindowWidth = 40;
            Symbol player = new Symbol();
            player.x = (Console.WindowWidth / 2) - 1;
            player.y = Console.WindowHeight - 1;
            player.c = "(0)";
            player.color = ConsoleColor.Gray;
            Random randomGenerator = new Random();
            List<Symbol> objects = new List<Symbol>();
            while (true)
            {
                PrintOnPosition(player.x, player.y, player.c, player.color);
                bool hitted = false;
                int chance = randomGenerator.Next(0, 100);
                if (chance <= 10)
                {
                    Symbol newSymbol = new Symbol();
                    newSymbol.color = ConsoleColor.Magenta;
                    newSymbol.x = randomGenerator.Next(0, Console.WindowWidth);
                    newSymbol.y = 1;
                    newSymbol.c = "%";
                    objects.Add(newSymbol);
                }
                else if (chance > 10 && chance <= 20)
                {
                    Symbol newSymbol = new Symbol();
                    newSymbol.color = ConsoleColor.Blue;
                    newSymbol.x = randomGenerator.Next(0, Console.WindowWidth);
                    newSymbol.y = 1;
                    newSymbol.c = "#";
                    objects.Add(newSymbol);
                }
                else if (chance > 20 && chance <= 30)
                {
                    Symbol newSymbol = new Symbol();
                    newSymbol.color = ConsoleColor.Yellow;
                    newSymbol.x = randomGenerator.Next(0, Console.WindowWidth);
                    newSymbol.y = 1;
                    newSymbol.c = "$";
                    objects.Add(newSymbol);
                }
                else if (chance > 30 && chance <= 40)
                {
                    Symbol newSymbol = new Symbol();
                    newSymbol.color = ConsoleColor.Cyan;
                    newSymbol.x = randomGenerator.Next(0, Console.WindowWidth);
                    newSymbol.y = 1;
                    newSymbol.c = "&";
                    objects.Add(newSymbol);
                }
                else if (chance > 40 && chance <= 50)
                {
                    Symbol newSymbol = new Symbol();
                    newSymbol.color = ConsoleColor.Green;
                    newSymbol.x = randomGenerator.Next(0, Console.WindowWidth);
                    newSymbol.y = 1;
                    newSymbol.c = "@";
                    objects.Add(newSymbol);
                }
                else if (chance > 50 && chance <= 60)
                {
                    Symbol newSymbol = new Symbol();
                    newSymbol.color = ConsoleColor.Red;
                    newSymbol.x = randomGenerator.Next(0, Console.WindowWidth);
                    newSymbol.y = 1;
                    newSymbol.c = "*";
                    objects.Add(newSymbol);
                }
                else if (chance > 60 && chance <= 70)
                {
                    Symbol newSymbol = new Symbol();
                    newSymbol.color = ConsoleColor.DarkYellow;
                    newSymbol.x = randomGenerator.Next(0, Console.WindowWidth);
                    newSymbol.y = 1;
                    newSymbol.c = "^";
                    objects.Add(newSymbol);
                }
                else if (chance > 70 && chance <= 80)
                {
                    Symbol newSymbol = new Symbol();
                    newSymbol.color = ConsoleColor.Gray;
                    newSymbol.x = randomGenerator.Next(0, Console.WindowWidth);
                    newSymbol.y = 1;
                    newSymbol.c = "!";
                    objects.Add(newSymbol);
                }
                else if (chance > 80 && chance <= 90)
                {
                    Symbol newSymbol = new Symbol();
                    newSymbol.color = ConsoleColor.DarkRed;
                    newSymbol.x = randomGenerator.Next(0, Console.WindowWidth);
                    newSymbol.y = 1;
                    newSymbol.c = "+";
                    objects.Add(newSymbol);
                }
                else if (chance > 90 && chance <= 100)
                {
                    Symbol newSymbol = new Symbol();
                    newSymbol.color = ConsoleColor.DarkGreen;
                    newSymbol.x = randomGenerator.Next(0, Console.WindowWidth);
                    newSymbol.y = 1;
                    newSymbol.c = ";";
                    objects.Add(newSymbol);
                }
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (player.x - 1 >= 0)
                        {
                            player.x = player.x - 1;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (player.x + 4 < Console.WindowWidth)
                        {
                            player.x = player.x + 1;
                        }
                    }
                }
                List<Symbol> newList = new List<Symbol>();
                for (int i = 0; i < objects.Count; i++)
                {
                    Symbol oldSymbol = objects[i];
                    Symbol newSymbol = new Symbol();
                    newSymbol.x = oldSymbol.x;
                    newSymbol.y = oldSymbol.y + 1;
                    newSymbol.c = oldSymbol.c;
                    newSymbol.color = oldSymbol.color;
                    if (newSymbol.y == player.y && newSymbol.x == player.x + 1)
                    {
                        livesCount--;
                        hitted = true;
                        if (livesCount <= 0)
                        {
                            PrintStringOnPosition(15, 9, "GAME OVER!!!", ConsoleColor.Red);
                            PrintStringOnPosition(10, 11, "Press [enter] to exit", ConsoleColor.Red);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                    if (newSymbol.y < Console.WindowHeight)
                    {
                        newList.Add(newSymbol);
                    }
                }
                objects = newList;
                if (hitted)
                {
                    objects.Clear();
                    PrintOnPosition(player.x + 1, player.y, "X", ConsoleColor.Red);
                }
                else
                {
                    PrintOnPosition(player.x, player.y, player.c, player.color);
                }
                foreach (Symbol symbol in objects)
                {
                    PrintOnPosition(symbol.x, symbol.y, symbol.c, symbol.color);
                }
                PrintStringOnPosition(15, 0, "Lives: " + livesCount, ConsoleColor.White);
                PrintStringOnPosition(0, 1, "-".PadRight(39, '-'), ConsoleColor.White);

                Thread.Sleep(150);
                Console.Clear();
            }
        }
    }
}

