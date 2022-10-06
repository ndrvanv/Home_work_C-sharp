// Примеры решения задач

/*void Task39()
{
    // Задача 39: Напишите программу, которая перевернет одномерный массив
    // (последний элемент будет на первом месте, а первый - на последнем и т. д.)
    Console.Clear();
    Console.WriteLine("**********************************\nНапишите программу, которая перевернет одномерный массив\n(последний элемент будет на первом месте, а первый - на последнем и т. д.");
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -10, 10);
    PrintArray(numbers);
    ReverseArray(numbers);

    PrintArray(numbers);
}

void ReverseArray(int[] numbers)
{
    int size = numbers.Length;
    int maxIndex = size - 1;
    for (int i = 0; i < size / 2; i++)
    {

        int temp = numbers[i];                     //  - переворачивает одномерный массив
        numbers[i] = numbers[maxIndex - i];
        numbers[maxIndex - i] = temp;
        //(numbers[i], numbers[maxIndex - i])=(numbers[maxIndex - i], numbers[i]);  // Кортеж или короткий способ переворота массива
    }
}


void FillArray(int[] numbers,
                int minValue = 0,
                int maxValue = 9)
{
    maxValue++;
    int size = numbers.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    int size = numbers.Length;
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}

//Task39();


void Task40()
{
    //Напишите программу, которая принимает на вход три числа и проверяет, 
    //может ли существовать треугольник со сторонами такой длины.
    //  Теорема о неравенстве треугольник: каждая сторона треугольника
    // меньше суммы двух других сторон
    Console.Clear();
    Console.WriteLine("//Напишите программу, которая принимает на вход три числа и проверяет,\nможет ли существовать треугольник со сторонами такой длины.\nТеорема о неравенстве треугольник: каждая сторона треугольника\nменьше суммы двух других сторон");
    Console.Write("");
    Random random = new Random();
    int NumA = random.Next(1, 9);
    Console.WriteLine("First number: " + NumA);
    int NumB = random.Next(1, 9);
    Console.WriteLine("Second number: " + NumB);
    int NumC = random.Next(1, 9);
    Console.WriteLine("Third number: " + NumC);
    
    if (NumA + NumB > NumC | NumA + NumC > NumB | NumB + NumC > NumA)
    {
        Console.WriteLine("This is triangle");
    }
    else
    {
        Console.WriteLine("It's not a triangle");
    }


}*/
//Task40();
int Input()
{
    Console.Write("Enter a number: ");
    return Convert.ToInt32(Console.ReadLine());
}

void Task41()
{
    //Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. 
    //Посчитайте, сколько чисел больше 0 ввёл пользователь.
    Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER.");
    int size = Input();
    Console.WriteLine("Enter a amount of numbers: " + size);
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    SortArray(numbers);
    //foreach (var i in numbers) { Console.Write(i + " "); }
}


void FillArray(int[] array)
{


    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Input();
    }
}


void PrintArray(int[] numbers)
{
    Console.WriteLine("Numbers:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}

void SortArray(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) count++;
    }
    Console.WriteLine("Numbers grater than zero " + count);
}


//Task41();

void Task43()
{
    //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
    //b1, k1, b2 и k2 задаются пользователем.
    //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями\n y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.\nb1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");
    double b1 = Input();
    double k1 = Input();
    double b2 = Input();
    double k2 = Input();
    if (k1 == k2)
    {
        Console.WriteLine("They are paralell");    //x = (b2 - b1) / (k1 - k2) y = k1 * x + b1
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        if (x == y)
        {
            Console.Write(x + " and " + y);
        }
    }
}
//Task43();

void Exit()
{
    Console.WriteLine("Bye!");
    Environment.Exit(4);
    Console.ReadKey();
}












// *************Выполнение команды*****************

void Main()
{   
    Console.Clear();
    Console.WriteLine(" Для вывода задач набирайте числа от 1 до 2, а для выхода нажиме 3 \n *****************************************************************");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1:
            Task41();
            Main();
            break;
        case 2:
            Task43();
            Main();
            break;
        case 3:
            Exit();
            Console.ReadKey();
            Console.Clear();
            break;            
    }
}
Main();
