void ShowNums(int n) //от одного до n
{
    if (i > 1)
        ShowNums(n - 1);
    Console.Write(n + " ");

}

ShowNums(5);
//  5 -> 4 ->3 ->2 ->1 ->2 -> 3 -> 4 -> 5 


//будет принимать на вход число и возвращать сумму его цифр.
//от одного до n

int sumOfDigits(int n)
{
    if (n >= 10)
    {
        return n % 10 + sumOfDigits(n / 10);

    }
    else return n;
}

ShowNums(n - 1);
Console.Write(n + " ");
Console.WriteLine(sumOfDigits(12345));


//Задайте значения M и N. выведет все натуральные в промежутке от M до N.
void ShouNum(int m, int n)
{

    if (n > m)
    {
        ShouNum(m, n - 1);
    }
    Console.Write(n + " ");

}
ShouNum(1, 10);



//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//a*bn   

//a=2   b=3 2*2*2

int Stepen(int a, int b)
{
    if (b > 1)
    {
        return a * Stepen(a, b - 1);
    }
    else return a;
}
Console.WriteLine();
Console.WriteLine(Stepen(4, 2));