﻿using System;

public class Pro2
{
    public static void Main()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write(j);


            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
