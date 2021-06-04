using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            char[,] mapForGame =
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ','X',' ',' ',' ',' ',' ',' ','#' },
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
            };
            int userX = 6, userY = 6;
            char[] bag = new char[0];
            
            while (true)
            {
                Console.SetCursorPosition(15, 0);
                Console.Write("сумка:");
                
                for (int i = 0; i < bag.Length; i++)
                {
                    Console.WriteLine(bag[i]);
                }

                Console.SetCursorPosition(0,0);
                for (int i = 0; i < mapForGame.GetLength(0); i++)
                {
                    for (int x = 0; x < mapForGame.GetLength(1); x++)
                    {
                        Console.Write(mapForGame[i, x]);
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(userY, userX);
                Console.Write("♥");
                ConsoleKeyInfo inputUserKey = Console.ReadKey();

                switch (inputUserKey.Key)
                {

                    case ConsoleKey.LeftArrow:
                        if (mapForGame[userX, userY - 1] != '#')
                        {
                            userY--;

                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (mapForGame[userX - 1, userY] != '#')
                        {
                            userX--;

                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (mapForGame[userX, userY - 1] != '#')
                        {
                            userY++;

                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (mapForGame[userX, userY - 1] != '#')
                        {
                            userX++;
                        }
                        break;

                }
                if (mapForGame[userX,userY] == 'X')
                {
                    mapForGame[userX, userY] = ' ';
                    for (int i = 0; i < bag.Length; i++)
                    {
                        Array.Resize(ref bag, bag.Length + 1);
                        bag[i] = 'x';
                    }
                }
                Console.Clear();
            }
        }
    }
}
