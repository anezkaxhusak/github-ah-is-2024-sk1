using System.Security.Authentication.ExtendedProtection;
using System.Diagnostics;

string again = "a";

while(again=="a"){



Console.Clear();
Console.WriteLine("***************************");
Console.WriteLine("****  *****");
Console.WriteLine("***************************");
Console.WriteLine("***** Anežka Husáková *****");
Console.WriteLine("***************************");
Console.WriteLine();

Console.Write("Zadejte počet generovaných čísel: ");
int n;
while(!int.TryParse(Console.ReadLine (), out n)){
    Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu");
}
Console.Write("Zadejte horní mez: ");
int hm;
while(!int.TryParse(Console.ReadLine (), out hm)){
    Console.Write("Nezadali jste celé číslo. ");
}
Console.Write("Zadejte dolní mez: ");
int dm;
while(!int.TryParse(Console.ReadLine (), out dm)){
    Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu");
}
Console.WriteLine();
Console.WriteLine("***************************");
Console.WriteLine("Zadané hodnoty: ");
Console.WriteLine("Počet čísel: {0}, dolní mez:{1}, horní mez: {2}", n, dm, hm);
Console.WriteLine("***************************");
Console.WriteLine();

//deklarace pole
int [] myArray = new int[n];

Random randomNumber = new Random();

Console.WriteLine("\n\nNáhodná čísla: ");
for(int i=0; i<n; i++){
myArray[i] = randomNumber.Next(dm, hm);
Console.Write("{0}; ", myArray[i]);
}
Stopwatch myStopwatch = new Stopwatch();

int myCompare = 0;
int myChange = 0;


myStopwatch.Start();
for(int i = 0; int < n-1; int++) {
    for(int j = 0; j < n-i-1 ; j++) {
        for(int myCompare++);
        if(myArray[j] > myArray[j+1]){
            int tmp = myArray [j+1];
            myArray [j+1] = myArray [j];
            myArray[j] = tmp;
            myChange++;
        }
    }
}

myStopwatch-Stop();
Console.WriteLine("\n\n\nSeřazené pole");
for(int i=0; i<n; i++){
Console.Write("{0}; ", myArray[i]);
}

Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("Čas potřebný na seřazení pole pomocí algoritmu Bubble sort: {0}", myStopwatch.Elapsed);

Console.WriteLine("\n\nPočet porovníní: {0}", myCompare);
Console.WriteLine("\nPočet výměn: {0}", myChange);

Console.ResetColor();
Console.WriteLine();
Console.WriteLine("Pro opakování programu stiskněte klávesu A");
again = Console.ReadLine();

}