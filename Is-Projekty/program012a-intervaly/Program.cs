string again = "a";

while(again=="a"){



Console.Clear();
Console.WriteLine("***************************");
Console.WriteLine("**** Generátor pseudonáhodných čísel *****");
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


int [] myArray = new int[n];
int int1 = 0;
int int2 = 0;
int int3 = 0;
int int4 = 0;

Random randomNumber = new Random();

Console.WriteLine("\n\nNáhodná čísla: ");
for(int i=0; i<n; i++){
myArray[i] = randomNumber.Next(dm, hm+1);
Console.Write("{0}; ", myArray[i]);

 if(myArray[i] <= (0.25 * hm)) {
    int1++ ;
 }
else if(myArray[i]<= (0.5 * hm)){
    int2++ ;
}
else if(myArray[i]<= (0.75 * hm)){
    int3++ ;
}
else 
int4++ ;
}

Console.WriteLine("\n Interval <{0}, {1}>: {2}", dm, 0.25 * hm, int1);
Console.WriteLine("\n Interval <{0}, {1}>: {2}", dm, 0.25 * hm + 1, 0.5 * hm, int2);
Console.WriteLine("\n Interval <{0}, {1}>: {2}", dm, 0.5 * hm + 1, 0.75 * hm, int3);
Console.WriteLine("\n Interval <{0}, {1}>: {2}", dm, 0.75 * hm + 1, 1 * hm, int4);

Console.WriteLine();
Console.WriteLine("Pro opakování programu stiskněte klávesu A");
again = Console.ReadLine();

}