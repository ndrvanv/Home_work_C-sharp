Console.Clear();
Console.Write("Введите первое число: ");
string input = Console.ReadLine(); 
int num1 = int.Parse(input); 

Console.Write("Введите второе число: ");
string input2 = Console.ReadLine();
int num2 = int.Parse(input2); 

if (num1 > num2)
{
    Console.WriteLine($"max = {num1} min = {num2}");
} 

else if (num1 == num2)
{
    Console.WriteLine($"Числа равны и ответ будет: {num1}");
}

else
{
    Console.WriteLine($"max = {num2} min = {num1}");
}
