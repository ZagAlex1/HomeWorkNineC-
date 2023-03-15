// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

System.Console.WriteLine(SumElements(PutNumber("Введите начальное число : ")
                                   , PutNumber("Введите конечное число : ")));

int PutNumber(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumElements(int firstNumber, int secondNumber)
{
    int sum = firstNumber;
    if (firstNumber == secondNumber)
        return firstNumber;
    else
        return sum + SumElements(firstNumber + 1, secondNumber);
}