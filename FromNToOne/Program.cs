//  Задайте значение N. Напишите программу, которая выведет 
//  все натуральные числа в промежутке от N до 1. 
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
System.Console.WriteLine(ShowNumbersFromNToOne(PutNumber("Введите число : ")));

int PutNumber(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string ShowNumbersFromNToOne(int number)
{
    if (number == 1)
        return number + " ";
    else
        return number + " " + ShowNumbersFromNToOne(number - 1);
}
