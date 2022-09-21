/*Console.Clear();
Console.Write("Введите число: ");
string a = Console.ReadLine();
char[] ch = a.ToCharArray();  
int length = a.Length;   
if (ch[0] == '-')
{
    Console.Write(ch[3]);
}
else if (length < 3)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    Console.WriteLine(ch[2]);
}*/

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = Math.Abs(num);

if (num1 < 100)
{
    Console.WriteLine("Введите трехзначное число!: ");
}
else if (num1 >= 100 && num1 <= 999)
{
    Console.WriteLine(num1 % 10);
}
else if (num1 > 999)
{
    while (num1 > 999)
    {
        num1 = num1 / 10;
        if (num1 <= 999 && num1 >= 100)
        {
            Console.WriteLine(num1 % 10);
        }
        
    }
}