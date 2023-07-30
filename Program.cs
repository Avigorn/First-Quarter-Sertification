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

string line1 = ReadInt("Введите первую строку");
string line2 = ReadInt("Введите вторую строку");
string line3 = ReadInt("Введите третью строку");