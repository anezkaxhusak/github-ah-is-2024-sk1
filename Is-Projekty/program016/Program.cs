using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

string again = "a";
        
        while(again == "a") {
             Console.Clear();
                razítko();
                ulong a = nacistCislo("Zadejte číslo a: ");
                ulong b = nacistCislo("Zadejte číslo b: ");

                ulong nsd = vypocitatNSD(a, b);
                ulong nsn = vypocitatNSN(a, b, nsd);

                zobrazitVysledky(a, b, nsd, nsn);
           
            Console.WriteLine("\nPro opakování programu stiskněte klávesu A");
            Console.ReadLine();

        }
        static void razítko (){
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*********************");
            Console.WriteLine("***** NSD a NSN *****");
            Console.WriteLine("*********************");
            Console.WriteLine("*********************");
            Console.WriteLine();

        }
    static ulong nacistCislo(string zprava) {
        Console.Write(zprava);
        ulong cislo;
        while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
          Console.Write("Nezadali jste přirozené číslo. Zadejte znovu: ");
        }
        return cislo;
        }
    static ulong vypocitatNSD(ulong a, ulong b){
        while (a != b) {
            if (a > b)
                a = a - b;
            else 
            b = b -a;
    }
        return a;
    }
    static ulong vypocitatNSN(ulong a, ulong b, ulong nsd){
        return (a*b/nsd);
    }
    static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn){
        Console.ForegroundColor= ConsoleColor.Green;
        Console.WriteLine("\nNSD čísel {0} a {1} je {2}", a, b, nsd);
        Console.ForegroundColor= ConsoleColor.Blue;
        Console.WriteLine($"\nNSN čísel {a} a {b} je {nsn}");
        Console.ForegroundColor= ConsoleColor.White;
    }
     