namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] map = new int[4, 4];
            Console.WriteLine("Hello, World!");
            map[0, 0] = 2;
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            bool b = true;
            bool move = false;
            while (true)
            {
                move = false;
                b = true;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(map[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        for (int i = 0; i < 4; i++)
                        {
                            if (map[i, 3] == 0 && map[i, 2] != 0)
                            {
                                map[i, 3] = map[i, 2];
                                map[i, 2] = 0;
                                move = true;
                            }
                            if (map[i, 3] == map[i, 2] && map[i, 2] != 0)
                            {
                                map[i, 3] *= 2;
                                map[i, 2] = 0;
                                move = true;
                            }
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            if (map[i, 2] == 0 && map[i, 1] != 0)
                            {
                                map[i, 2] = map[i, 1];
                                map[i, 1] = 0;
                                move = true;
                            }
                            if (map[i, 2] == map[i, 1] && map[i, 1] != 0)
                            {
                                map[i, 2] *= 2;
                                map[i, 1] = 0;
                                move = true;
                            }
                            if (map[i, 3] == 0 && map[i, 2] != 0)
                            {
                                map[i, 3] = map[i, 2];
                                map[i, 2] = 0;
                                move = true;
                            }
                            if (map[i, 3] == map[i, 2] && map[i, 2] != 0)
                            {
                                map[i, 3] *= 2;
                                map[i, 2] = 0;
                                move = true;
                            }
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            if (map[i, 1] == 0 && map[i, 0] != 0)
                            {
                                map[i, 1] = map[i, 0];
                                map[i, 0] = 0;
                                move = true;
                            }
                            if (map[i, 1] == map[i, 0] && map[i, 0] != 0)
                            {
                                map[i, 1] *= 2;
                                map[i, 0] = 0;
                                move = true;
                            }
                            if (map[i, 2] == 0 && map[i, 1] != 0)
                            {
                                map[i, 2] = map[i, 1];
                                map[i, 1] = 0;
                                move = true;
                            }
                            if (map[i, 2] == map[i, 1] && map[i, 1] != 0)
                            {
                                map[i, 2] *= 2;
                                map[i, 1] = 0;
                                move = true;
                            }
                            if (map[i, 3] == 0 && map[i, 2] != 0)
                            {
                                map[i, 3] = map[i, 2];
                                map[i, 2] = 0;
                                move = true;
                            }
                            if (map[i, 3] == map[i, 2] && map[i, 2] != 0)
                            {
                                map[i, 3] *= 2;
                                map[i, 2] = 0;
                                move = true;
                            }
                        }
                        if (move)
                        {
                            while (b)
                            {
                                int x = rnd1.Next(0, 4);
                                int y = rnd2.Next(0, 4);
                                if (map[x, y] == 0)
                                {
                                    map[x, y] = 2;
                                    b = false;
                                }
                            }

                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        for (int i = 3; i >= 0; i--)
                        {
                            if (map[i, 0] == 0 && map[i, 1] != 0)
                            {
                                map[i, 0] = map[i, 1];
                                map[i, 1] = 0;
                                move = true;
                            }
                            if (map[i, 0] == map[i, 1] && map[i, 1] != 0)
                            {
                                map[i, 0] *= 2;
                                map[i, 1] = 0;
                                move = true;
                            }
                        }
                        for (int i = 3; i >= 0; i--)
                        {
                            if (map[i, 1] == 0 && map[i, 2] != 0)
                            {
                                map[i, 1] = map[i, 2];
                                map[i, 2] = 0;
                                move = true;
                            }
                            if (map[i, 1] == map[i, 2] && map[i, 2] != 0)
                            {
                                map[i, 1] *= 2;
                                map[i, 2] = 0;
                                move = true;
                            }
                            if (map[i, 0] == 0 && map[i, 1] != 0)
                            {
                                map[i, 0] = map[i, 1];
                                map[i, 1] = 0;
                                move = true;
                            }
                            if (map[i, 0] == map[i, 1] && map[i, 1] != 0)
                            {
                                map[i, 0] *= 2;
                                map[i, 1] = 0;
                                move = true;
                            }
                        }
                        for (int i = 3; i >= 0; i--)
                        {
                            if (map[i, 2] == 0 && map[i, 3] != 0)
                            {
                                map[i, 2] = map[i, 3];
                                map[i, 3] = 0;
                                move = true;
                            }
                            if (map[i, 2] == map[i, 3] && map[i, 3] != 0)
                            {
                                map[i, 2] *= 2;
                                map[i, 3] = 0;
                                move = true;
                            }
                            if (map[i, 1] == 0 && map[i, 2] != 0)
                            {
                                map[i, 1] = map[i, 2];
                                map[i, 2] = 0;
                                move = true;
                            }
                            if (map[i, 1] == map[i, 2] && map[i, 2] != 0)
                            {
                                map[i, 1] *= 2;
                                map[i, 2] = 0;
                                move = true;
                            }
                            if (map[i, 0] == 0 && map[i, 1] != 0)
                            {
                                map[i, 0] = map[i, 1];
                                map[i, 1] = 0;
                                move = true;
                            }
                            if (map[i, 0] == map[i, 1] && map[i, 1] != 0)
                            {
                                map[i, 0] *= 2;
                                map[i, 1] = 0;
                                move = true;
                            }
                        }
                        if (move)
                        {
                            while (b)
                            {
                                int x = rnd1.Next(0, 4);
                                int y = rnd2.Next(0, 4);
                                if (map[x, y] == 0)
                                {
                                    map[x, y] = 2;
                                    b = false;
                                }
                            }

                        }
                        break;

                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        for (int i = 3; i >= 0; i--)
                        {
                            if (map[0, i] == 0 && map[1, i] != 0)
                            {
                                map[0, i] = map[1, i];
                                map[1, i] = 0;
                                move = true;
                            }
                            if (map[0, i] == map[1, i] && map[1, i] != 0)
                            {
                                map[0, i] *= 2;
                                map[1, i] = 0;
                                move = true;
                            }
                        }
                        for (int i = 3; i >= 0; i--)
                        {
                            if (map[1, i] == 0 && map[2, i] != 0)
                            {
                                map[1, i] = map[2, i];
                                map[2, i] = 0;
                                move = true;
                            }
                            if (map[1, i] == map[2, i] && map[2, i] != 0)
                            {
                                map[1, i] *= 2;
                                map[2, i] = 0;
                                move = true;
                            }
                            if (map[ 0, i] == 0 && map[ 1, i] != 0)
                            {
                                map[ 0, i] = map[ 1, i];
                                map[ 1, i] = 0;
                                move = true;
                            }
                            if (map[ 0, i] == map[ 1, i] && map[ 1, i] != 0)
                            {
                                map[ 0, i] *= 2;
                                map[ 1, i] = 0;
                                move = true;
                            }
                        }
                        for (int i = 3; i >= 0; i--)
                        {
                            if (map[2, i] == 0 && map[3, i] != 0)
                            {
                                map[2, i] = map[3, i];
                                map[3, i] = 0;
                                move = true;
                            }
                            if (map[2, i] == map[3, i] && map[3, i] != 0)
                            {
                                map[2, i] *= 2;
                                map[3, i] = 0;
                                move = true;
                            }
                            if (map[1, i] == 0 && map[2, i] != 0)
                            {
                                map[1, i] = map[2, i];
                                map[2, i] = 0;
                                move = true;
                            }
                            if (map[1, i] == map[2, i] && map[2, i] != 0)
                            {
                                map[1, i] *= 2;
                                map[2, i] = 0;
                                move = true;
                            }
                            if (map[0, i] == 0 && map[1, i] != 0)
                            {
                                map[0, i] = map[1, i];
                                map[1, i] = 0;
                                move = true;
                            }
                            if (map[0, i] == map[1, i] && map[1, i] != 0)
                            {
                                map[0, i] *= 2;
                                map[1, i] = 0;
                                move = true;
                            }
                        }
                        if (move)
                        {
                            while (b)
                            {
                                int x = rnd1.Next(0, 4);
                                int y = rnd2.Next(0, 4);
                                if (map[x, y] == 0)
                                {
                                    map[x, y] = 2;
                                    b = false;
                                }
                            }

                        }
                        break;

                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        for (int i = 0; i < 4; i++)
                        {
                            if (map[3, i] == 0 && map[ 2, i] != 0)
                            {
                                map[ 3, i] = map[ 2, i];
                                map[ 2, i] = 0;
                                move = true;
                            }
                            if (map[ 3, i] == map[ 2, i] && map[ 2, i] != 0)
                            {
                                map[ 3, i] *= 2;
                                map[ 2, i] = 0;
                                move = true;
                            }
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            if (map[ 2, i] == 0 && map[ 1, i] != 0)
                            {
                                map[ 2, i] = map[ 1, i];
                                map[ 1, i] = 0;
                                move = true;
                            }
                            if (map[ 2, i] == map[ 1, i] && map[ 1, i] != 0)
                            {
                                map[ 2, i] *= 2;
                                map[ 1, i] = 0;
                                move = true;
                            }
                            if (map[ 3, i] == 0 && map[ 2, i] != 0)
                            {
                                map[ 3, i] = map[ 2, i];
                                map[ 2, i] = 0;
                                move = true;
                            }
                            if (map[ 3, i] == map[ 2, i] && map[ 2, i] != 0)
                            {
                                map[ 3, i] *= 2;
                                map[ 2, i] = 0;
                                move = true;
                            }
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            if (map[ 1, i] == 0 && map[ 0, i] != 0)
                            {
                                map[ 1, i] = map[ 0, i];
                                map[ 0, i] = 0;
                                move = true;
                            }
                            if (map[ 1, i] == map[ 0, i] && map[ 0, i] != 0)
                            {
                                map[ 1, i] *= 2;
                                map[ 0, i] = 0;
                                move = true;
                            }
                            if (map[ 2, i] == 0 && map[ 1, i] != 0)
                            {
                                map[ 2, i] = map[ 1, i];
                                map[ 1, i] = 0;
                                move = true;
                            }
                            if (map[ 2, i] == map[ 1, i] && map[ 1, i] != 0)
                            {
                                map[ 2, i] *= 2;
                                map[ 1, i] = 0;
                                move = true;
                            }
                            if (map[ 3, i] == 0 && map[ 2, i] != 0)
                            {
                                map[ 3, i] = map[ 2, i];
                                map[ 2, i] = 0;
                                move = true;
                            }
                            if (map[ 3, i] == map[ 2, i] && map[ 2, i] != 0)
                            {
                                map[ 3, i] *= 2;
                                map[ 2, i] = 0;
                                move = true;
                            }
                        }
                        if (move)
                        {
                            while (b)
                            {
                                int x = rnd1.Next(0, 4);
                                int y = rnd2.Next(0, 4);
                                if (map[x, y] == 0)
                                {
                                    map[x, y] = 2;
                                    b = false;
                                }
                            }

                        }

                        break;
                }
            }
        }
    }
}