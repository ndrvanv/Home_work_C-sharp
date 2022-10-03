namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] FillArrayOne()     //Метод наполнения массива, для первой задачи
            {
                Random rnd = new Random();
                double[] array = new double[rnd.Next(1, 9)];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(100, 1000);
                }

                return array;
            }

            void PrintArray(double[] array)    //Метод печати массива
            {
                Console.WriteLine();
                Console.WriteLine("[" + String.Join("; ", array) + "]"); // Короткая версия
                /*Console.Write("[");  - Длинная версия кода
                for (int i = 0; i < num.Length; i++)
                {
                    if (i < array.Length - 1)
                        Console.Write(array[i] + ", ");
                    else
                        Console.Write(array[i]);
                }
                Console.Write("]");
                return num;*/
            }

            void SortArrayOne(double[] array)  //Метод обработка массива по позициям для первой задачи
            {
                double count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine("Number of odd array elements: " + count);
            }

            double[] FillArrayTwo()     //Метод наполнения массива для второй задачи
            {
                Random rnd = new Random();
                double[] array = new double[rnd.Next(1, 9)];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(-10, 1000);
                }

                return array;
            }

            void SortArrayTwo(double[] array) // Обработка не четных элементов массива
            {
                double count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        count = array[i] + count;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(" Sum of elements:" + count);
            }

            double[] FillArrayThree()     //Метод наполнения массива для второй задачи
            {
                Random rnd = new Random();
                double[] array = new double[rnd.Next(1, 9)];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Math.Round(rnd.NextDouble() + rnd.Next(-10, 1000), 2);
                }

                return array;
            }

            void Difference(double[] array)  // Разница между максимальным и минимальным значнинем элемнтов массива
            {
                double MinNum = array[0];
                double MaxNum = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < MinNum)
                    {
                        MinNum = array[i];
                    }
                    else if (array[i] > MaxNum)
                    {
                        MaxNum = array[i];
                    }

                }
                Console.WriteLine("Difference between Maximal number and minimal equal: " + Math.Round((MaxNum - MinNum), 2));
            }


            void TaskOne()
            {
                /*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
                Напишите программу, которая покажет количество чётных чисел в массиве. 
                [345, 897, 568, 234] -> 2*/

                Console.Clear();
                Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.\n Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2");
                double[] array = FillArrayOne();
                PrintArray(array);
                SortArrayOne(array);
                Console.ReadKey();
            }

            void TaskTwo()
            {
                /*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
                Найдите сумму элементов, стоящих на нечётных позициях.[3, 7, 23, 12] -> 19
                [-4, -6, 89, 6] -> 0*/
                Console.Clear();
                Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами.\n Найдите сумму элементов, стоящих на нечётных позициях.[3, 7, 23, 12] -> 19 \n [-4, -6, 89, 6] -> 0");
                double[] array = FillArrayTwo();
                PrintArray(array);
                SortArrayTwo(array);
                Console.ReadKey();
            }

            void TaskThree()
            {
                /*Задача 38: Задайте массив вещественных чисел. 
                Найдите разницу между максимальным и минимальным элементов массива.
                [3 7 22 2 78] -> 76*/
                Console.Clear();
                Console.WriteLine("Задача 38: Задайте массив вещественных чисел. \n Найдите разницу между максимальным и минимальным элементов массива.[3 7 22 2 78] -> 76");
                double[] array = FillArrayThree();
                PrintArray(array);
                Console.WriteLine();
                Difference(array);
                Console.ReadKey();
            }

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
                Console.WriteLine(" Для вывода задач набирайте числа от 1 до 3, а для выхода нажиме 4 \n *****************************************************************");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        TaskOne();
                        Main();
                        break;
                    case 2:
                        TaskTwo();
                        Main();
                        break;
                    case 3:
                        TaskThree();
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
        }
    }
}