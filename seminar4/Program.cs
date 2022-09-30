/*Console.Clear();
 
Console.Write("Введите размер массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);
 
int[] array = new int[arrayLenght];
 
FillArray(array);
PrintArray(array);
 
 
 
void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(0, 2);
    }
}
 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
*/
/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Ограничения:
- Нельзя использовать класс Math
- Должна быть отдельная функция Power, которая возвразает результат
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода*/

/*Console.Clear();
Console.Write("Enter a first number: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter a second number: ");
int b = int.Parse(Console.ReadLine()!);

int Task(int num1, int num2)
{
    int gen = 1;
    int i = 1;
    for (i = 1; i <= b; i++)
    {
        gen = gen * a;
    }
    return gen;
}
int Pow = Task(a, b);
Console.WriteLine(Pow);*/


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
Ограничения:
- Должна быть отдельная функция, которая возвразает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода*/


/*int Task2(string number, int counter)
{
    int num = Convert.ToInt32(number);
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

Console.Clear();
Console.Write("Enter a number: ");
string num = Console.ReadLine()?? "0";
int sumNum = Task2(num, num.Length);
Console.WriteLine(sumNum);*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
Ограничения:
- Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
- Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода*/

Console.Write("Введите размер массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);

int[] array = new int[arrayLenght];

FillArray(array);
PrintArray(array);
SortArray(array);


void FillArray(int[] xyz)
{
    Random randGenerator = new Random();
    for (int i = 0; i < xyz.Length; i++)
    {
        xyz[i] = randGenerator.Next(0, 9);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
      if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i]);
    }
}

void SortArray(int[] array)
{
    Console.WriteLine();
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i]);
    Console.Write(" ]");

}