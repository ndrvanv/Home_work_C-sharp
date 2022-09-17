Console.Clear();
Console.Write("Введите число: ");
String input = Console.ReadLine();
int num = int.Parse(input);
if (num % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}
