// 1
using System.Runtime.InteropServices;

string[] toys = { "lego", "Pussel", "Boll", "barbie", "penn"};


// 2
Console.WriteLine("Leksaker");
foreach (string toy in toys)
{
    Console.WriteLine(toy);
}


// 3
List<string> classmates = ["Haroon", "John", "Wing", "Dac", "Mostafa"];

// 4
int[] ratings ={ 5, 6, 7, 8, 9};


// 5
Console.WriteLine("\nBetygssättning av leksaker: ");
for (int i = 0; i < classmates.Count; i++)
{
    Console.WriteLine($"{classmates} ger {toys} betyget {ratings}");
}

// 6
List<string> cities= [""];

Console.ReadLine();





Console.ReadLine();