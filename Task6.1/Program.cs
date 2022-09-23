// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


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
int[] promptArray(string message, int velue)
{
    int[] array = new int[velue];
    Console.WriteLine(message);
    for (int i = 0; i < velue; i++)
    {
        bool isDigit = int.TryParse(Console.ReadLine(), out int number);
        if (isDigit)
        {
            array[i] = number;
        }
        else
        { throw new Exception("Вы ввели не число"); }
    }
    return array;
}
int positivElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
void writePositivElement(int[] array)
{
    for(int i = 0;i < array.Length;i++)
    {
        System.Console.Write($"{array[i]} \t");
    }
    System.Console.WriteLine($"Количество цифр больше нуля : {positivElement(array)}");
}
int velueA = Prompt("Введите длину массива : ");
int[] arrayA = promptArray($"Введите {velueA} чисел", velueA);
writePositivElement( arrayA);