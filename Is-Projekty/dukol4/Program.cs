﻿class Program
{
    static void Main()
    {
        int size = 7;         
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
            
                if (i +  j >= size / 2 && j - i <= size / 2 && i - j <= size / 2 && i + j <= 3 * size / 2 - 1 )
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");                 }
            }
            Console.WriteLine();         }
    }
}