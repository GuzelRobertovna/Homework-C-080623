// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int MinNumber = Prompt("Задайте минимальное значение : ");
int MaxNumber = Prompt("Задайте максимальное значение : ");
Console.WriteLine($"Сумма натуральных чисел в диапазоне от {MinNumber} до {MaxNumber}: {NaturalNumber(0, MinNumber, MaxNumber)}");


int NaturalNumber(int summa, int minValue, int maxValue)
{
    if (minValue > maxValue || maxValue <= 0) return summa;
    else if (minValue <= 0) minValue = 1;
    summa += minValue;
    minValue++;
    int sum = NaturalNumber(summa, minValue, maxValue);
    return sum;
}


int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}
