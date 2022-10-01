// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

int SumOfnumbers(int m, int n)
{
    if (n >= m)
    {
        if (n - m == 0) return m;
        return n + SumOfnumbers(m, n - 1);
    } else
    {
        if (m - n == 0) return n;
        return m + SumOfnumbers(m-1, n);
    }
}

int number1 = Prompt("Введите число m : ");
int number2 = Prompt("Введите число n : ");
int sumOfnambers = SumOfnumbers(number1, number2);
Console.WriteLine(sumOfnambers);
