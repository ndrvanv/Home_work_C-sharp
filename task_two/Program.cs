Console.Clear();
Console.Write("Введите первое число: ");
string input = Console.ReadLine();
int num1 = int.Parse(input);

Console.Write("Введите второе число: ");
string input2 = Console.ReadLine();
int num2 = int.Parse(input2);

Console.Write("Введите третье число: ");
string input3 = Console.ReadLine();
int num3 = int.Parse(input3);

int[] i = { num1, num2, num3 };
int maxValue = i.Max();


Console.Write($"Максимальное число: {maxValue}");