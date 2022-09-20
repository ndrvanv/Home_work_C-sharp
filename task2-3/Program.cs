Console.Clear();
Console.Write("Введите число дня недели: ");
int num = int.Parse(Console.ReadLine());

if (0 < num && num <= 7)
{
    if (num <= 5)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }
}
else
{
    Console.Write("Введите число от одного до семи!");
}