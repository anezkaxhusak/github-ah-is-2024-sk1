﻿string again = "a";

while (again == "a")
{


    Console.WriteLine("***************************");
    Console.WriteLine("**** Ciferný součet****");
    Console.WriteLine("***************************");
    Console.WriteLine("***** Anežka Husáková *****");
    Console.WriteLine("***************************");
    Console.WriteLine();

    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu");
    }
    int suma = 0;
    int multi = 1;
    int numberBackup = number;
    int digit;
    

    number = Math.Abs(number); // 

    while(number >= 10) {
        digit = number % 10;
        number = (number-digit)/10;
        Console.WriteLine("Digit = {0}", digit);
        suma = suma + digit;
        multi = multi * digit;

      
    }
    Console.WriteLine("Digit = {0}", number);

//musíme přičíst ještě poslední cifru
    suma = suma + number;

multi = multi * number;
    Console.WriteLine();
    Console.WriteLine("\n\n\n Součet cifer čísla {0} je {1}", numberBackup, suma);
    Console.WriteLine("\n Součin cifer čísla {0} je {1}", numberBackup, multi);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu A");
    again = Console.ReadLine();
}