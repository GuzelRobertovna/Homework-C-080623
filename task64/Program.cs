// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

int MinNumber = Prompt("Задайте минимальное значение : ");
int MaxNumber = Prompt("Задайте максимальное значение : ");
Console.WriteLine($"Натуральные числа в диапазоне от {MinNumber} до {MaxNumber}:");
NaturalNumber(MinNumber, MaxNumber);
Console.WriteLine();


void NaturalNumber(int minValue, int maxValue)
{
    if (minValue > maxValue || maxValue <= 0) return;
    else if (minValue <= 0) minValue = 1;
    Console.Write($"{minValue} ");
    minValue++;
    NaturalNumber(minValue, maxValue);
}


int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

