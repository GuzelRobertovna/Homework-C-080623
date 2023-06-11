// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29


Console.Write("Введите первое неотрицательное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана равно {AkkermanFunction(number1, number2)} ");

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}
