using System.Security.Authentication.ExtendedProtection;

string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("==========================================");
            Console.WriteLine();

            //deklarace pole    
            int[] myArray = new int[n];

            Random randomNumber = new Random();

            Console.WriteLine("\n\nNáhodná čísla:");
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]); 
            }

            







           

             int max = myArray[0];
             int min = myArray[0];
             int poziceMax = 0;
             int poziceMin = 0;
            for(int i = 1; i < n; i++ ) {
                if(myArray[i] > max) {
                    max = myArray[i];
                    poziceMax = i;
                }

                if(myArray[i] < min){
                    min = myArray[i];
                    poziceMin = i;
        
                }
                int x;
                var pocetCisel = hm;
                var soucetCisel = x;
                foreach(var X in myArray)

                Console.WriteLine($"Aritmetický průměr = {}" / $"{pocetCisel}");

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
           

        }
        }