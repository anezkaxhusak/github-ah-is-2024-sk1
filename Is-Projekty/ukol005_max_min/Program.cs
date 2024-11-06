while(again=="a"){



Console.Clear();
Console.WriteLine("***************************");
Console.WriteLine("**** Maximum a Minimum*****");
Console.WriteLine("***************************");
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

int max = myArray[0];
int min = myArray[0] ;
// 5 10 
int poziceMax = i;
int poziceMin = ;

for(int i = 1 ; i < n; i++){
    if(myArray[i] > max){
        max = myArray[i];
        poziceMax = i;
    }
    if(myArray [i] < min){
        min = myArray[i];
        poziceMin = i;
    }
}

Console.WriteLine("\n\nMaximum = {0}; jeho prvni pozice v poli = {1}", max, poziceMax);
Console-WriteLine("Minimum = {0}; jeho prvni pozice v poli ={i}", min, poziceMin);
Console.WriteLine();
Console.WriteLine("Pro opakování programu stiskněte klávesu A");
again = Console.ReadLine();

}