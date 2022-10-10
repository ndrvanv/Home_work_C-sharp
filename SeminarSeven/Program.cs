/*Console.Clear();
// Задайте трехмерный массив размером m * n * z, заполненный случайными целыми числами (от 0 до 99).

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите z: ");
int z = int.Parse(Console.ReadLine()!);
 
int[,,] array = new int[m, n, z];
FillArray(array);
PrintArray(array);
 
 
 
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
 
 
 
void FillArray(int[,,] array)
{
    Random generator = new Random();
 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = generator.Next(0,100);
            }
        }
    }
}*/

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5


/*Console.Clear();
 
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
 
 
 
void PrintArray(int[,] Printarray)
{
    for (int i = 0; i < Printarray.GetLength(0); i++)
    {
        for (int j = 0; j < Printarray.GetLength(1); j++)
        {
            Console.Write($"{Printarray[i,j]} ");
            
        }
        Console.WriteLine();
    }
}
 
 
 
void FillArray(int[,] array)
{
    
 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
        }
    }
}*/

//Задача 49: Задайте двумерный массив. Найдите элементы, 
//у которых оба индекса чётные, и замените эти элементы на их квадраты.





//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.




void PrintArray(double[,] Printarray)
{
    for (int i = 0; i < Printarray.GetLength(0); i++)
    {
        for (int j = 0; j < Printarray.GetLength(1); j++)
        {
            Console.Write($"{Printarray[i, j]} ");

        }
        Console.WriteLine();
    }
}

void FillArray(double[,] array)
{
    Random generator = new Random();
    double minValue = -10;
    double mixValue = 100;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(generator.NextDouble() * (mixValue - minValue) + minValue, 1);
        }
    }
}

void PrintArray2(int[,] Printarray)
{
    int rows = Printarray.GetLength(0);
    int columns = Printarray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{Printarray[i, j]} ");

        }
        Console.WriteLine();
    }
}

void FillArray2(int[,] array)
{
    Random generator = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = generator.Next(-10, 100);
        }
    }
}

void FindIndex(int[,] FindInd, int a, int b)
{
    int rows = FindInd.GetLength(0);
    int columns = FindInd.GetLength(1);
    int index = 0;
    if (a > 0 && b > 0 && a <= rows && b <= columns)
    {
        for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            index = FindInd[a - 1, b - 1];
        }
    }
    Console.WriteLine("Значение элемента равна: "+index);
    }
    else
    {
        Console.WriteLine($"{a} и {b}: таких элементов нет в массиве");
    }
}

void AverageColumn(int[,] FindInd)
{
    int rows = FindInd.GetLength(0);
    int columns = FindInd.GetLength(1);
    double averSum = 0;
    for (int j = 0; j < columns; j++)
    {   
        double Sum = 0;
        for (int i = 0; i < rows; i++)
        {
            Sum +=FindInd[i, j]; 
        }
        Console.Write("");
        averSum = Math.Round(Sum / rows, 1);
        Console.WriteLine($"Среднее арифметическое {j+1} столбца = {averSum}");
    }
}


void Task47()
{
    //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    Console.Clear();
    Console.WriteLine("Задача 47. Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.");
    Console.Write("Введите m: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите n: ");
    int n = int.Parse(Console.ReadLine()!);

    double[,] array = new double[m, n];
    FillArray(array);
    PrintArray(array);
}
//Task47();

void Task50()
{
    // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    //и возвращает значение этого элемента или же указание, что такого элемента нет.
    Console.Clear();
    Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,\nи возвращает значение этого элемента или же указание, что такого элемента нет:");
    Console.Write("Введите m: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Введите n: ");
    int columns = int.Parse(Console.ReadLine()!);

    int[,] array = new int[rows, columns];
    FillArray2(array);
    PrintArray2(array);
    Console.WriteLine("");
    Console.Write("Введите число для элемета строки: ");
    int numLine = int.Parse(Console.ReadLine()!);
    Console.Write("Введите число для элемета столбца: ");
    int numColumn = int.Parse(Console.ReadLine()!);
    FindIndex(array, numLine, numColumn);
}
//Task50();


void Task52()
{
    //Задача 52. Задайте двумерный массив из целых чисел. 
    //Найдите среднее арифметическое элементов в каждом столбце.
    Console.Clear();
    Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. \nНайдите среднее арифметическое элементов в каждом столбце.");
    Console.Write("Введите m: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите n: ");
    int n = int.Parse(Console.ReadLine()!);

    int[,] array = new int[m, n];
    FillArray2(array);
    PrintArray2(array);
    AverageColumn(array);

}
//Task52();

void Exit()
{
    Console.WriteLine("Bye!");
    Environment.Exit(4);
    Console.ReadKey();
}

// *************Выполнение команды*****************



void Main()
{
    //Console.Clear();
    Console.WriteLine(" Для вывода задач набирайте числа от 1 до 3, а для выхода нажиме 4 \n *****************************************************************");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1:
            Task47();
            Main();
            break;
        case 2:
            Task50();
            Main();
            break;
        case 3:
            Task52();
            Main();
            break;
        case 4:
            Exit();
            Console.ReadKey();
            Console.Clear();
            break;
    }
}
Main();


