//Домашняя работа к 7 семинару
/*Console.Clear();
int[,] matrix = new int[3, 3];
 
Random generator = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = generator.Next(0, 10);
    }
}
 
PrintMatrix(matrix);
Console.WriteLine();
PrintArray(CalcAverage(matrix));
 
 
// Console.Write("Введите индекс строки: ");
// int row = int.Parse(Console.ReadLine()!);
// Console.Write("Введите индекс столбца: ");
// int column = int.Parse(Console.ReadLine()!);
 
// if (IsIndexExists(matrix, row, column))
// {
//     Console.WriteLine(matrix[row, column]);
// }
// else
// {
//     Console.WriteLine("Элемента с таким индексом не существует");
// }
 
double[] CalcAverage(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j,i];
        }
        result[i] = sum / matrix.GetLength(0);
    }
    return result;
}
 
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}
 
bool IsIndexExists(int[,] matrix, int row, int column)
{
    if (row < matrix.GetLength(0) &&
        column < matrix.GetLength(1) &&
        row >= 0 && column >= 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
*/

//Семинар Сапрыкина 
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


/*int[,] matrix = new int[5,5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
RepleceRowArray(matrix);
PrintArray(matrix);


void RepleceRowArray(int[,] array)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0 , j] ;
        array[0 , j] = array[array.GetLength(1) - 1 , j];
        array[array.GetLength(1) - 1 , j] = temp;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(1, 10);
        }
    }
}
*/

// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

/*/Console.Clear();
int[,] matrix = new int[4,4];
Random generator = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = generator.Next(100, 200);
    }
}
 
PrintArray(matrix);
Console.WriteLine();
 
int[] rowArray = MatrixToRow(matrix);
GetFrequense(rowArray);
 
 
int[] MatrixToRow(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[index] = matrix[i, j];
            index++;
        }
    }
    return result;
}
 
void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}
 
 
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
 
void GetFrequense(int[] sortedArray)
{
    SortArray(sortedArray);
    Console.WriteLine(string.Join(" ", rowArray));
    int currentElement = sortedArray[0];
    int count = 1;
    for (int i = 1; i < sortedArray.Length; i++)
    {
        if (sortedArray[i] != currentElement)
        {
            Console.WriteLine($"{currentElement} встречается {count}");
            currentElement = sortedArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{currentElement} встречается {count}");
}

*/
//Семинар Сапрыкина 
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Задайте двумерный массив из целый чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива
/*void Zadacha59()
{
    //var Random = new Random();
    int rows = 3;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArray1(numbers);
    PrintArray1(numbers);
}*/
//Zadacha59();
/*void FillArray1(int[,] numbers)
{
    //Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = i + j;
        }
    }
}
void PrintArray1(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}
*/


// ***********************************Домашка*************************************************************
//Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

void FillArrayInOrder(int[,] array)  //Спирально 4 х 4
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int value = 1;
    int startRow = 0;
    int startColumn = 0;
    int j = 0;

    for (int i = startRow; i < columns;)
    {
        while ((i, j) != (startRow + 1, startColumn))
        {
            array[i, j] = value;
            value++;
            if (i == startRow && j != columns - 1)
            {
                j++;
            }
            else if (i != rows - 1 && j == columns - 1)
            {
                i++;
            }
            else if (i == rows - 1 && j != startColumn)
            {
                j--;
            }
            else if (i != startRow + 1 && j == startColumn)
            {
                i--;
            }
            array[i, j] = value;
        }
        startRow++;
        startColumn++;
        columns--;
        rows--;
    }
}

void FillArray(int[,] array)
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

void PrintArray(int[,] Printarray)
{
    int rows = Printarray.GetLength(0);
    int columns = Printarray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{Printarray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void DecreasingArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            for (int k = 0; k < columns - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];   // (array[i, k], array[i, k + 1]) = (array[i, k + 1], array[i, k]); - 3 строки заменяются кортежем
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}

void MinSum(int[,] minElement)
{
    int[] arr = new int[minElement.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < minElement.GetLength(0); i++)
    {
        for (int j = 0; j < minElement.GetLength(1); j++)
        {
            sum += minElement[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} элемента равна: {sum}");
        arr[i] = sum;
    }
    int minValue = arr[0];
    int minIndex = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (minValue > arr[i])
        {
            minValue = arr[i];
            minIndex = i + 1;
        }
    }
    Console.WriteLine($"Индекс минимального значения строки: {minIndex}");

}

void MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    Console.WriteLine();
    PrintArray(result);
}

void FillArray3D(int[,,] array3D)
{
    Random generator = new Random();
    int rows = array3D.GetLength(0);
    int columns = array3D.GetLength(1);
    int depth = array3D.GetLength(2);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                array3D[i, j, k] = generator.Next(0, 10);
            }
        }
    }
}

void PrintArray3D(int[,,] array3D)  //Ввывод массива с индексами значения
{
    Random generator = new Random();
    int rows = array3D.GetLength(0);
    int columns = array3D.GetLength(1);
    int depth = array3D.GetLength(2);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                Console.Write($"{array3D[i, j, k]} ({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}

void Task54()
{
    //Задайте двумерный массив. Напишите программу, которая упорядочит 
    //по убыванию элементы каждой строки двумерного массива.
    Console.Clear();
    Console.Write("Задайте двумерный массив. Напишите программу,\nкоторая упорядочит по убыванию элементы каждой строки двумерного массива.");
    Console.WriteLine("");
    Console.Write("Введите колличество строк: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Введите колличество столбцов: ");
    int column = int.Parse(Console.ReadLine()!);
    int[,] matrix = new int[row, column];

    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine("");
    DecreasingArray(matrix);
    PrintArray(matrix);
}
//Task54();

void Task56()
{
    //Задайте прямоугольный двумерный массив. Напишите программу, 
    //которая будет находить строку с наименьшей суммой элементов.
    Console.Clear();
    Console.Write("Задайте прямоугольный двумерный массив. Напишите программу, \nкоторая будет находить строку с наименьшей суммой элементов.");
    Console.WriteLine("");
    Console.Write("Введите колличество строк: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Введите колличество столбцов: ");
    int column = int.Parse(Console.ReadLine()!);
    int[,] matrix = new int[row, column];
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine("");
    MinSum(matrix);

}
//Task56();

void Task58()
{
    //Задача 58: Задайте две матрицы. Напишите программу, 
    //которая будет находить произведение двух матриц.
    Console.Clear();
    Console.Write("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
    Console.WriteLine();
    Console.Write("Введите колличество строк: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Введите колличество столбцов: ");
    int column = int.Parse(Console.ReadLine()!);
    int[,] matrixOne = new int[row, column];
    int[,] matrixTwo = new int[column, row];
    FillArray(matrixOne);
    PrintArray(matrixOne);
    Console.WriteLine("");
    FillArray(matrixTwo);
    PrintArray(matrixTwo);
    MultiplicationMatrix(matrixOne, matrixTwo);
}
//Task58();

void Task60()
{
    //Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    //Массив размером 2 x 2 x 2
    Console.Clear();
    Console.Write("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.\nНапишите программу, которая будет построчно выводить массив, \nдобавляя индексы каждого элемента. Массив размером 2 x 2 x 2");
    Console.WriteLine();
    Console.Write("Введите число для кубической матрицы: ");
    int row = int.Parse(Console.ReadLine()!);
    int[,,] matrix3D = new int[row, row, row];
    FillArray3D(matrix3D);
    PrintArray3D(matrix3D);

}
//Task60();

void Task62()
{
    //Напишите программу, которая заполнит спирально массив 4 на 4
    Console.Clear();
    Console.WriteLine("Напишите программу, которая заполнит спирально массив 4 на 4.");
    Console.WriteLine();
    //Console.Write("Введите колличество строк: ");
    //int row = int.Parse(Console.ReadLine()!);
    //Console.Write("Введите колличество столбцов: ");
    //int column = int.Parse(Console.ReadLine()!);
    int[,] matrix = new int[4, 4];
    FillArrayInOrder(matrix);
    PrintArray(matrix);
}
//Task62();

void Exit()
{
    Console.WriteLine("Bye!");
    Environment.Exit(4);
    Console.ReadKey();
}

void Main()
{
    //Console.Clear();
    Console.WriteLine(" Для вывода задач набирайте числа от 1 до 5, а для выхода нажиме 6 \n *****************************************************************");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1:
            Task54();
            Main();
            break;
        case 2:
            Task56();
            Main();
            break;
        case 3:
            Task58();
            Main();
            break;
        case 4:
            Task60();
            Main();
            break;
        case 5:
            Task62();
            Main();
            break;
        case 6:
            Exit();
            Console.ReadKey();
            Console.Clear();
            break;
    }
}
Main();