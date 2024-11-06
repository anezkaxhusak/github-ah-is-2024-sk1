class program {
 static void Main(){

while(again=="a"){
    



Console.Clear();
Console.WriteLine("***************************");
Console.WriteLine("**** Analýza textu *****");
Console.WriteLine("***************************");
Console.WriteLine("***************************");
Console.WriteLine();

Copnsole.WriteLine("\nZadejte váš text: ");
string myText = Console.ReadLine();

Console.WriteLine();
Console.WriteLine(myText{0});
Console.WriteLine(myText.Lenght);

string samohlaska = "aáeéěiíoóuúůyý";
string souhlaska = "bcčdďfghjklmnňpqrřsštťvwxz";
string cislice = "123456789";

int pocetSamohlasek = 0;
int pocetSouhlasek = 0;
int pocetCislic = 0;
int pocetOstatnich = 0;

foreach (char znak in myText ){
    if (souhlasky.Contains(znak)){
        pocetSouhlasek++;

    }
    else if (samohlasky.Contains(znak)){
        pocetSamohlasek++;
        
    }
    else if (cislice.Contains(znak)){
        pocetCislic++;
        
    }
    else
    pocetOstatnich++;
}

Console.WriteLine();
Console.WriteLine("Počet souhlásek: {0}", pocetSouhlasek);
Console.WriteLine("Počet samohlásek: {0}", pocetSamohlasek);
Console.WriteLine("Počet číslic: {0}", pocetCislic);
Console.WriteLine("Počet ostatních znaků: {0}", pocetOstatnich);

Console.WriteLine();
Console.WriteLine("Pro opakování programu stiskněte klávesu A");
again = Console.ReadLine();
}
}
}