Console.WriteLine("Привет. Введи по очереди несколько целых чисел(можно отрицательные). Когда надоест, введи слово " + "конец");

CountNegative(0);

void CountNegative(int count)
{
    string input = Console.ReadLine();
    if (input.ToLower() != "конец")
    {
        if (Int32.Parse(input) < 0)
        {
            count++;
        }
        CountNegative(count);
    }
    else
    {
        Console.WriteLine("вы ввели " + count + " отрицательных чисел");
    }
}
