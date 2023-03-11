// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int InputInt32(string message)
{
    System.Console.Write(($"{message}: "));
    int value;
    bool isCorrectInt32 = int.TryParse(Console.ReadLine(), out value);
    if (isCorrectInt32 && value > 0)
    {
        return value;
    }
    System.Console.WriteLine("You entered not a number or negative number");
    Environment.Exit(-1);
    return 0;
}

int SumNumbersInRange(int StartNumber, int EndNumber)
{
    if (StartNumber > EndNumber) return 0;
    return StartNumber + SumNumbersInRange(StartNumber + 1, EndNumber);
}
int StartNum = InputInt32("Enter Start number");
int EndNum = InputInt32("Enter End number");
if (StartNum < EndNum)
{
    System.Console.Write($"Sum all number in range ({StartNum}..{EndNum}) = {SumNumbersInRange(StartNum, EndNum)} ");
}
else System.Console.WriteLine("Error! End number must be  > StartNumber! ");