// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее
//  арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

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
            array[i, j] = rnd.Next(0, 101);
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
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();

    }
}

void PrintAverageValue(int[,] array)
{
    Console.WriteLine("Среднее значение по столбцам :");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double averageValue = 0;
        int n = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            averageValue += Convert.ToDouble(array[i, j]);
            n++;
        }
        averageValue = averageValue/n;
        Console.Write($"{averageValue:f2}\t");
    }
}


int[,] arrayA = PromptDimensionOftheArray("Введите количество строк m :",
"Введите количество столбцов n :");
PrintArray(PromptArray(arrayA));
PrintAverageValue(arrayA);




