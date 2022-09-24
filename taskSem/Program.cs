/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да 
*/


int Input()
{
    return Convert.ToInt32(Console.ReadLine());
}
void task_1()
{
    Console.WriteLine("enter a five digit-number: ");
    int num = Math.Abs(Input());
    int one = num / 10000 % 10;
    int two = num / 1000 % 10;
    int three = num / 100 % 10;
    int four = num / 10 % 10;
    int five = num % 10;
    if (num > 9999 && num < 100000){
    if (one == five && two == four)
    
        Console.WriteLine("Введенное число является палиндромом");
    
    else
    
        Console.WriteLine("Число не является палидромом");
    }
    else
    {
        Console.WriteLine("You need to enter a five digit-number!");
    }
}
task_1();


/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


void task_2()
{
    Console.Write("enter the first number for the first coordinate: ");
    int a1 = Input();
    Console.Write("enter the second number for the first coordinate: ");
    int a2 = Input();
    Console.Write("enter the third number for the first coordinate: ");
    int a3 = Input();
    Console.Write("enter the first number for the second coordinate: ");
    int b1 = Input();
    Console.Write("enter the second number for the second coordinate: ");
    int b2 = Input();
    Console.Write("enter the third number for the second coordinate: ");
    int b3 = Input();

    double ab = Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2 - a2, 2) + Math.Pow(b3 - a3, 2));
    Console.WriteLine(Math.Round(ab, 2));
}
task_2();

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void task_3()
{
    Console.Write("enter the number: ");
    int num = Math.Abs(Input());
    int count = 1;
    while (count <= num)
    {
        Console.Write(Math.Pow(count, 3));
        if (count != num)
        {
            Console.Write(", ");
        }
        count++;
    }
}
task_3();