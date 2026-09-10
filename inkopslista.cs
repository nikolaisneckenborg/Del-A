List<string> varor = [];
List<int> priser = [];
bool felinput = false;
bool dyrast = false;

static void dyrastevaror(List<string> varor, List<int> priser)
{
    int index = 1;
    int max = priser.Max();
    for(int i = 0; i < varor.Count; i++)
    {
        if(priser[i] == max)
        {
            Console.WriteLine($"{index}. {varor[i]} - {priser[i]} kr");
            index++;
        }
    }
}

while (true)
{
    if (varor.Count < 1)
    {
        Console.WriteLine("Det finns inga varor i inköpslistan.");
    }
    else if (dyrast)
    {
        dyrastevaror(varor, priser);
        dyrast = false;
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
        Console.Write("Ogiltigt input, försök igen: ");
    }
    else
    {
        Console.Write("Input från användaren: ");
    }
    string? input = Console.ReadLine()!.Trim();
    if(int.TryParse(input, out int nummer))
    {
        if(nummer<1 || nummer > varor.Count)
        {
            felinput = true;
        }
        else
        {
            varor.RemoveAt(nummer-1);
            priser.RemoveAt(nummer-1);
            felinput = false;
        }
    }
    else if(input == "dyrast")
    {
        if (varor.Count > 0)
        {
            dyrast = true;
        }
        else
        {
            felinput = true;
        }
    }
    else
    {
        Console.Write("Ange ett pris för varan: ");
        if(int.TryParse(Console.ReadLine(), out int pris)){
            varor.Add(input);
            priser.Add(pris);
            felinput = false;
        }
        else
        {
            felinput = true;
        }
    }
    Console.Clear();
}