using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._07study2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 2];
            array[0, 0] = 1;
            array[0, 1] = 2;
            array[1, 0] = 3;
            array[1, 1] = 4;
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(array[i, j] + " ");
                    
                }
                
            }
            Console.Write("\n");

            int[,,] Earray = { {{ 1,2}, { 3,4} },
                                 { {5,6 },{7, 8 } } };
            for(int i= 0; i< 2; i++)
            {
                for(int j=0; j<2; j++)
                {
                    for(int k = 0; k <2; k++)
                    {
                        Console.Write(Earray[i, j, k] + " "); 
                    }
                    
                }
            }
            Console.Write("\n");
        }
    }
}
