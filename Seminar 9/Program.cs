void ShowNums(int n) //от одного до n
{
    if(i > 1)
        ShowNums(n-1);
    Console.Write(n + " ");

}

ShowNums(5);
//  5 -> 4 ->3 ->2 ->1 ->2 -> 3 -> 4 -> 5 


//будет принимать на вход число и возвращать сумму его цифр.
//от одного до n

int sumOfDigits(int n)
{
    if(n>=10)
    {
        return n%10 + sumOfDigits(n/10);

    }
    else return n;
}
    
ShowNums(n-1);
Console.Write(n + " ");
Console.WriteLine(sumOfDigits(12345));


//Задайте значения M и N. выведет все натуральные в промежутке от M до N.
