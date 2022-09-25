// Задача 1. Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] PromptDimensionOftheArray(string message1, string message2)
{
    Console.WriteLine(message1);
    int numberOfRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(message2);
    int numberOfColumns = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[numberOfRows, numberOfColumns];
    return array;
}


double[,] PromptArray(double[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)


        {
            array[i, j] = rnd.NextDouble() * 100 - 50;
        }


    }
    return array;
}


void PrintArray(double[,] array)
{
    Console.WriteLine($"m = {array.GetLength(0)} n = {array.GetLength(1)}");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)


        {
            System.Console.Write($"{array[i, j]:f2} \t\t");
        }
        System.Console.WriteLine();

    }
}


double[,] arrayA = PromptDimensionOftheArray("Введите количество строк m :",
"Введите количество столбцов n :");
PrintArray(PromptArray(arrayA));