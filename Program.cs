Console.Clear();
string ReadInt(string message)
{
    System.Console.Write($"{message}: ");
    string inputedString = Console.ReadLine();
    return inputedString;
}

void CheckSymbols(string rows)
{
    if (rows.Length <= 3)
    {
        System.Console.WriteLine(rows);
    }
}