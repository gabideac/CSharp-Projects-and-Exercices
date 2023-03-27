using System;

namespace ProblemaTransoane
{
    class Program
    {
        static void Main()
        {
            int pathsNr = Convert.ToInt32(Console.ReadLine());
            string[] thePath = InsertPaths(pathsNr);
            int[][] coordinates = GetPathCoordinates(thePath);
            bool repeatedPoints = CheckForDuplicates(coordinates);
            Console.WriteLine(repeatedPoints);
            Console.ReadLine();
        }

        static string[] InsertPaths(int pathsNr)
        {
            string[] paths = new string[pathsNr];

            for (int i = 0; i < pathsNr; i++)
            {
                paths[i] = Console.ReadLine();
            }

            return paths;
        }

        static int[][] GetPathCoordinates(string[] thePath)
        {
            int[][] coordinates = new int[thePath.Length + 1][];
            int x = 0;
            int y = 0;
            const int two = 2;
            coordinates[thePath.Length] = new[] { 0, 0 };
            for (int i = 0; i < thePath.Length; i++)
            {
                coordinates[i] = new int[two];
                coordinates[i][0] = x;
                coordinates[i][1] = y;
                switch (thePath[i])
                {
                    case "up":
                        y++;
                        coordinates[i][1] = y;
                        break;
                    case "down":
                        y--;
                        coordinates[i][1] = y;
                        break;
                    case "right":
                        x++;
                        coordinates[i][0] = x;
                        break;
                    case "left":
                        x--;
                        coordinates[i][0] = x;
                        break;
                }
            }

            return coordinates;
        }

        static bool CheckForDuplicates(int[][] coordinates)
        {
            bool check = false;
            foreach (int[] point in coordinates)
            {
                int count = 0;
                for (int i = 0; i < coordinates.Length; i++)
                {
                    if (point[0] == coordinates[i][0] && point[1] == coordinates[i][1])
                    {
                        count++;
                    }

                    if (count > 1)
                    {
                        check = true;
                        break;
                    }
                }
            }

            return check;
        }
    }
}
