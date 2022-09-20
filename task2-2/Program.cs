Console.Clear();
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
}