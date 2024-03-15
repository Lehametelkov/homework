// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

int FuncAkkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    if (m == 0)
        return FuncAkkerman(n - 1, 1);
    else return FuncAkkerman(n - 1, FuncAkkerman(n, m - 1));

}

void NaturalNumTest(int n, int m)
{
    if (n < 0 || m < 0)
    {
        Console.WriteLine("Числа не натуральные");
        Environment.Exit(0); // не получалось завершить программу на этом моменте, пришлось покопаться в интернете
    }

}
Console.WriteLine("Введите значение n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение m");
int m = Convert.ToInt32(Console.ReadLine());

NaturalNumTest(n,m);
int result = FuncAkkerman(n, m);
Console.WriteLine(result);