﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._07study4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][][] array = new int[2][][];
            array[0] = new int[2][];
            array[1] = new int[3][];

            array[0][0] = new int[] { 1, 2, 3 };
            array[0][1] = new int[] { 4, 5 };

            array[1][0] = new int[] { 6, 7, 8 };
            array[1][1] = new int[] { 9, 10 };
            array[1][2] = new int[] { 11, 12 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    for (int k = 0; k < array[i][j].Length; k++)
                    {
                        Console.Write("{0}", array[i][j][k] + "");
                    }
                }
            }
        }
    }
}
