using System.Runtime.InteropServices;

List<string> varor = [];
List<int> priser = [];

while (true)
{
    if (varor.Count < 1)
    {
        Console.WriteLine("Det finns inga varor i inköpslistan.");
        varor.Add("Mjölk");
        varor.Add("Bröd");
        priser.Add(15);
        priser.Add(32);
    }
    else
    {
        for(int i = 0; i < varor.Count; i++)
        {
            Console.WriteLine($"{i+1}. {varor[i]} - {priser[i]} kr");
        }
        Console.WriteLine($"Totalt: {priser.Sum()} kr");
    }
    Console.ReadLine();
}