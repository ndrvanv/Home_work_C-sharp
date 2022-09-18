Console.Clear();
Console.Write("Введите число: ");
string input = Console.ReadLine();
int num = Math.Abs(int.Parse(input));

int count = 2;

if (num % 2 == 0)
{
    while (num >= count)
{
    Console.Write($"{count} ");
    count = count + 2;
}
}

else if (num % 2 != 0)
{
    num = num - 1;
    while (num >= count)
    {
      Console.Write($"{count} ");
    count = count + 2;  
    }
}