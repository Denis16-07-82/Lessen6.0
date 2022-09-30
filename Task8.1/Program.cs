// Задача 1: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой
// строки двумерного массива.

int[,] PromptDimensionOftheArray(string message1, string message2)
{
    Console.WriteLine(message1);
    int numberOfRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(message2);
    int numberOfColumns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[numberOfRows, numberOfColumns];
    return array;
}

int[,] PromptArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)


        {
            array[i, j] = rnd.Next(0, 51);
        }


    }
    return array;
}

int[,] sortingArray(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            int maxElement = array[0, i];
            for (int j = i; j < array.GetLength(1); j++)
            {
                if (array[k, j] > maxElement)
                {
                    maxElement = array[k, j];
                    array[k, j] = array[k, i];
                    array[k, i] = maxElement;
                }
            }
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine($"m = {array.GetLength(0)} n = {array.GetLength(1)}");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)


        {
            System.Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();

    }
}

int[,] arrayNull = PromptDimensionOftheArray("Введите количество строк m :",
"Введите количество столбцов n :");
int[,] arrayRand = PromptArray(arrayNull);
PrintArray(arrayRand);
int[,] arraySort = sortingArray(arrayRand);
PrintArray(arraySort);

