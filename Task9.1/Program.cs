// Задача 1: Задайте значение N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

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

void PrintingNumbers(int n)
{
    if(n == 0) return;
    Console.Write($" {n} ");
    PrintingNumbers(n-1);
    
}


int number = Prompt("Введите число : ");
PrintingNumbers(number);