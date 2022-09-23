// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] promptArray(string message)
{
    double[,] array = new double[3, 3];
    Console.WriteLine(message);
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            bool isDigit = double.TryParse(Console.ReadLine(), out double number);
            if (isDigit)
            {
                array[i, j] = number;
            }
            else
            { throw new Exception("Вы ввели не число"); }
        }
    }
    return array;
}


double[,] algArray(double[,] array, int a, int b)
{
    double[,] arrayA = new double[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int i = 0;
    int j = 0;
    for (int i1 = 0; i1 < array.GetLength(0); i1++)
    {
        if (i1 != a)
        {
            for (int j1 = 0; j1 < array.GetLength(1); j1++)
            {
                if (j1 != b)
                {
                    arrayA[i, j] = array[i1, j1];
                    j++;
                }
            }
            i++;
            j = 0;
        }



    }
    return arrayA;
}

double detFan(double[,] array)
{
    if (array.GetLength(0) == 2 && array.GetLength(1) == 2)
    { return array[0, 0] * array[1, 1] - array[0, 1] * array[1, 0]; }
    double det = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double[,] arrayA = algArray(array, 0, j);
        det += array[0, j] * Math.Pow(-1, j) * detFan(arrayA);
    }
    return det;
}
double[,] array = promptArray("Введите матрицу 3 * 3");

for (int j = 0; j < array.GetLength(1); j++)
{
    double[,] arrayA = algArray(array, 0, j++);
    System.Console.WriteLine($"{arrayA[0, 0]} , {arrayA[0, 1]} , {arrayA[1, 0]} , {arrayA[1, 1]}");
}

double determinant = detFan(array);
System.Console.WriteLine(determinant);