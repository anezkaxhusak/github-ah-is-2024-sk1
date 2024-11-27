using System.Security.Authentication.ExtendedProtection;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

string again = "a";


        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Převod z 10 soustavy do 2 *****");
            Console.WriteLine("*******************************************");
            Console.WriteLine("************* Anežka H *****************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Console.Write("Zadejte Zadejte číslo v 10 soustavě (přirozené číslo): ");
           uint cislo;
            while(!uint.TryParse(Console.ReadLine(), out cislo)) {
                Console.Write("Nezadali jste celé číslo. Zadejte číslo v 10 soustavěznovu: ");
            }
        

           uint[] myArray = new uint[32];
           uint zaloha = cislo;
           uint zbytek;

    uint i;
           for(i=0; cislo > 0; i++){ 
           {
            zbytek = cislo % 2;
         cislo = (cislo = zbytek)/2;
         myArray[i] = zbytek;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Celá část = {0}; Zbytek = {1}", cislo, zbytek );

           }

            Console.WriteLine("\n Poslední využitá buňka pole: {0}", i-1);

            Console.ForegroundColor = ConsoleColor.Yellow;
        
            Console.WriteLine("\n\nVýsledek: ");
            for (uint j = i - 1 ; j >= 0 ; j--); 
            {
            Console.Write("{0}", myArray[j]);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu A");
           }

        }