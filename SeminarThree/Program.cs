//принимает на вход точки (X и Y), причём X ≠ 0 и Y ≠ 0. вывод номер четверти плоскости.
int ShowArea(int a, int b)
{
    int result = -1;

    if (a > 0 && b > 0) result = 1;
    if (a < 0 && b > 0) result = 2;
    if (a < 0 && b < 0) result = 3;
    if (a > 0 && b < 0) result = 4;
    return result;
}

Console.WriteLine("Input x : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ShowArea(x, y));


//принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.



