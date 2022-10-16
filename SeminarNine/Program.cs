


// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
/*Console.Clear();
Console.WriteLine("Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.");
Console.Write("Задайте значение: ");
int number = int.Parse(Console.ReadLine()!);
int count = 0;
Task63(number);
void Task63(int Number)
{ 

count++;
Console.Write(count + " ");
if (count >= number)
{

    return;
}
Task63(number);
}
*/


//Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N
/*Console.Clear();
Console.WriteLine("Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.");
Console.Write("Введите начальный числовой промежуток M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечный числовой промежуток N: ");
int N = int.Parse(Console.ReadLine()!);

Task65(M, N);
void Task65(int num, int count = 1)
{
    Console.Write(count + " ");
    count++;
    if (count >= M)
    {
        return;
    }
    Task65(M, count);
}
*/




void Task67()
{
    //Напишите программу, которая будет принимать на вход число и возращать сумму его цифр
    //453 -> 12
    Console.Clear();
    Console.WriteLine("Напишите программу, которая будет принимать на вход число и возращать сумму его цифр");
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine()!);
    Console.WriteLine(Sum(num));
}
//Task67();

int Sum(int num, int sum = 0)
{
    if (num == 0)
    {
        return sum;
    }
    sum = sum + num % 10;
    num = num / 10;
    return Sum(num, sum);
}


    //Напишите программу, которая на вход принимает два числа А и В. и возводит число А в целую степень В с помощью рекурсии.
    //А = 3. В = 5 -> 243 (3^5)
    Console.Clear();
    Console.WriteLine("Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.");
    Console.Write("Введите число: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.Write("Введите число возводимую в степень: ");
    int b = int.Parse(Console.ReadLine()!);
    
    int result = 1;

    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    Console.Write($"{a}^{b} = {result}");




