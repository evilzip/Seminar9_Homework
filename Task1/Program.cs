// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

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

void PrintNaturalNumber(int StartNumber, int FinishNumber)
{

    if (StartNumber > FinishNumber) return;
    StartNumber = StartNumber + StartNumber % 2;//если StartNumber нечетное, то начнем вывод чисел со следующего за ним четного. А если StartNumber четное, то с него и начинаем. 
    System.Console.Write($"{StartNumber} ");
    PrintNaturalNumber(StartNumber + 2, FinishNumber);

}

int StartNum = InputInt32("Enter Start number");
int EndNum = InputInt32("Enter End number");
if (StartNum < EndNum)
{
    System.Console.Write($"All even number in range [{StartNum}..{EndNum}]: ");
    PrintNaturalNumber(StartNum, EndNum);
}
else System.Console.WriteLine("Error! End number must be  > StartNumber! ");