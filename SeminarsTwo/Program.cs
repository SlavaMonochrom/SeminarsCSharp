//проверка числа на кратность 7 & 23

bool secondTaskFirst(int numberTaskSecond)
{   
    Console.WriteLine("input: ");
    if (numberTaskSecond /2 ==0 & numberTaskSecond % 23 ==0)
        return true;
    else 
        return false;
}
Console.WriteLine("Введите число: ");
int numberTaskSecond = Convert.ToInt32(Console.ReadLine());
