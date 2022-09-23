// Задача 3: (*)
// Найдите максимальное значение в матрице по каждой строке, получите сумму
//  этих максимумов. Затем найдите минимальное значение по каждой колонке,
//  получите сумму этих минимумов. Затем из первой суммы (с максимумами) 
//  вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int[,] promptArray(string message)
{
    int[,] array = new int[5, 5];
    Console.WriteLine(message);
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)


        {
            array[i, j] = new Random().Next(-100, 101);
        }


    }
    return array;
}
void writeArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)


        {
            System.Console.Write($" {array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();

}
int summMaks(int[,] array)
{
    int sumMaxLines = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j =0;
        int maximumArray = array[i, j];
        for ( j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > maximumArray) maximumArray = array[i, j];
        }
        sumMaxLines += maximumArray;
    }
    return sumMaxLines;
}
int summMin(int[,] array)
{
    int sumMinColumns = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int i = 0;
        int minimumArray = array[i, j];
        for ( i = 0; i < array.GetLength(0); i++)
        {
            if (array[i, j] < minimumArray) minimumArray = array[i, j];
        }
        sumMinColumns += minimumArray;
    }
    return sumMinColumns;
}
int[,] arrayA = promptArray("Квадратная матрица 5 на 5");
writeArray(arrayA);
int sumMaxLines = summMaks(arrayA);
int sumMinColumns = summMin(arrayA);
System.Console.WriteLine($"Разность сумм максимумов строк и столбцов : {sumMaxLines - sumMinColumns}");