// Задача 3: Задайте две матрицы.
//  Напишите программу, которая будет находить произведение двух матриц.

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
            array[i, j] = rnd.Next(0, 10);
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


int[,] MultiplicationOftwomatrices(int[,] arrayA, int[,] arrayB)//умножение двух матриц.
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int m = 0; m < arrayC.GetLength(0); m++)
    {
        for (int i = 0; i < arrayC.GetLength(1); i++)
        {
            for (int j = 0; j < arrayA.GetLength(1); j++)
            {
                arrayC[m, i] += arrayA[m, j] * arrayB[j, i];
            }
        }
    }
    return arrayC;
}

Console.WriteLine("Для матрицы A :");
int[,] arrayNull1 = PromptDimensionOftheArray("Введите количество строк m :",
"Введите количество столбцов n :");
int[,] arrayRand1 = PromptArray(arrayNull1);
Console.WriteLine("Для матрицы B :");
int[,] arrayNull2 = PromptDimensionOftheArray("Введите количество строк m :",
"Введите количество столбцов n :");
int[,] arrayRand2 = PromptArray(arrayNull2);

if (arrayRand1.GetLength(1) == arrayRand2.GetLength(0))
{
    PrintArray(arrayRand1);
    PrintArray(arrayRand2);
    int[,] arrayC = MultiplicationOftwomatrices(arrayRand1, arrayRand2);
    Console.WriteLine("Произведение матриц A и B :");
    PrintArray(arrayC);
}
else System.Console.WriteLine("Произведение матриц невозможно.");



