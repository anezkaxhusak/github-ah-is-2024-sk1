// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


double zacatek=5;
double difference = 4;
int pocet = 5;

double temp=zacatek;
double soucet = 0;

for(int  i = 0; i < pocet;i++){
    temp  += difference;  //temp = temp + diference
    soucet += temp;
    Console.WriteLine($"Prvek {i} posloupnost: {temp}");
}
Console.WriteLine($"Soucet  {soucet}");
