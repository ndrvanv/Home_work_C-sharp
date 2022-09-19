Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());

if (100 <= a && a <= 999)
{
    Console.WriteLine(a / 10 % 10);
}
else
{
    Console.WriteLine("Введите трехзначное число!");
}