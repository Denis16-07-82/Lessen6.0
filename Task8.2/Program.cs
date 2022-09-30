// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.


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

int[] OneDimensionalArray(int[,] rectangularArray)//одномерный массив из сумм строки по столбцам
{
    int[] array = new int[rectangularArray.GetLength(0)];
    for (int i = 0; i < rectangularArray.GetLength(0); i++)
    {
        for (int j = 0; j < rectangularArray.GetLength(1); j++)
        {
            array[i] += rectangularArray[i, j];
        }
    }
    return array;
}



int IndexMinimumValue(int[] array)//Возвращает индекс с минимумом в массиве
{
    int minimumValue = array[0];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minimumValue)
        {
            minimumValue = array[i];
            j = i;
        }
    }
    return j;
}


void PrintLineMinAmount(int[,] array,int velue)
{
    Console.WriteLine("Строка с минимальной суммой :");
    Console.WriteLine();
    for(int j = 0;j < array.GetLength(1);j++)
    {
        Console.Write($"{array[velue,j]} \t");
    }
}

int[,] arrayNull = PromptDimensionOftheArray("Введите количество строк m :",
"Введите количество столбцов n :");
int[,] arrayRand = PromptArray(arrayNull);
PrintArray(arrayRand);
int[] arrayA = OneDimensionalArray(arrayRand);
int indexMinimum = IndexMinimumValue(arrayA);
PrintLineMinAmount(arrayRand,indexMinimum);

