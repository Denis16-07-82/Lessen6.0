// Задача 2. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание,
//   что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет


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
            array[i, j] = rnd.Next(0,101);
        }


    }
    return array;
}


int PromptIndexNumber(string message1)
{
    Console.WriteLine(message1);
    int indexNumber = Convert.ToInt32(Console.ReadLine());
    return indexNumber;
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


void PrintElementArray(int[,] array,int lineNumber,int columnNumber)
{
    
    
    if(lineNumber < array.GetLength(0) && columnNumber < array.GetLength(1))
    {
        Console.WriteLine($"Номер строки: {lineNumber}, номер столбца : {columnNumber}");
        Console.Write($"Элемент массива : {array[lineNumber - 1,columnNumber -1]} ");
    }
    else Console.WriteLine("Элемента с такими индексами нет.");
}

int[,] arrayA = PromptDimensionOftheArray("Введите количество строк m :",
"Введите количество столбцов n :");
PrintArray(PromptArray(arrayA));
int lineNumber = PromptIndexNumber("Введите номер строки :");
int columnNumber = PromptIndexNumber("Введите номер столбца :");
PrintElementArray(arrayA,lineNumber,columnNumber);



