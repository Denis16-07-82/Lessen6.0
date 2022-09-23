// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[,] promptArray(string message)
{
    double[,] array = new double[2, 2];
    Console.WriteLine(message);
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
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
string intersectionPoint(double[,] array)
{
    if (array[0, 0] - array[1, 0] != 0)
    {
        double[] point = new double[2];
        point[0] = (array[1, 1] - array[0, 1]) / (array[0, 0] - array[1, 0]);
        point[1] = array[0, 0] * point[0] + array[0, 1];
        return $"Точка пересечения двух прямых {point[0]} , {point[1]}";
    }
    if(array[1, 1] - array[0, 1] != 0) return $"Прямые параллельны и точек пересечения нет. ";
    else return $"Прямые совпадают";
}
double[,] arrayA = promptArray("Введите коэффициэнты прямых k1 , b1 , k2 , b2");
Console.WriteLine(intersectionPoint(arrayA));
