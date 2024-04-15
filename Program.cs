using System;
namespace jagged
{
    public class Pattern
    {
        public static void Main()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[5];
            jaggedArray[2] = new int[6];
            jaggedArray[3] = new int[4];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = i * j + 60;
                    Console.WriteLine("CPU usage of {0} node is {1}%", i + 1, jaggedArray[i][j]);

                }
            }
        }
    }

}

