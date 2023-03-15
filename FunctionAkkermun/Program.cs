// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

System.Console.WriteLine(Akkermun(PutNumber("Введите m : ")
                                , PutNumber("Введите n : ")));

int PutNumber(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Akkermun(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Akkermun(m - 1, 1);
    else if (m > 0 && n > 0)
        return Akkermun(m - 1, Akkermun(m, n - 1));
    return 0;
}