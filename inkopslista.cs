List<string> varor = [];
List<int> priser = [];
bool felinput = false;

while (true)
{
    if (varor.Count < 1)
    {
        Console.WriteLine("Det finns inga varor i inköpslistan.");
    }
    else
    {
        for(int i = 0; i < varor.Count; i++)
        {
            Console.WriteLine($"{i+1}. {varor[i]} - {priser[i]} kr");
        }
        Console.WriteLine($"Totalt: {priser.Sum()} kr");
    }
    if (felinput)
    {
        Console.Write("Ogiltigt pris, försök igen: ");
    }
    else
    {
        Console.Write("Input från användaren: ");
    }
    string? vara = Console.ReadLine()!.Trim();
    Console.Write("Ange ett pris för varan: ");
    if(int.TryParse(Console.ReadLine(), out int pris)){
        varor.Add(vara);
        priser.Add(pris);
        felinput = false;
    }
    else
    {
        felinput = true;
    }
    Console.Clear();
}