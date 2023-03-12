// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputInt32(string message)
{
    System.Console.Write(($"{message}: "));
    int value;
    bool isCorrectInt32 = int.TryParse(Console.ReadLine(), out value);
    if (isCorrectInt32 && value >= 0)
    {
        return value;
    }
    System.Console.WriteLine("You entered not a number or negative number");
    Environment.Exit(-1);
    return 0;
}

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

int m = InputInt32("Enter 1st argument (m)");
int n = InputInt32("Enter 2nd argument (n)");

System.Console.WriteLine($"Akkerman function A({m},{n}) = {AkkermanFunction(m, n)}");