int[,] CreateRandon2dArray(int rows, int collums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, collums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < collums; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

int[,] Quad(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j; i < Array.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0) Array[i,j] = Array[i,j] * Array[i,j];
    return Array[]

}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // 0 - строка
    {
        for (int j = 0; j < array.GetLength(1); j++)  // .GetLenth(1) - столбец для многомерных массивов 
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int FindDiagSum(int[,] array)
{
    int sum = 0;
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, i];
        /*
        {
            for (int j = 0; j < array.GetLength(1); j++)
                if (i == j) sum += array[i, j];

        }*/
    }
    return sum;
}



Console.Write("Input numbers of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of collums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandon2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine("Sum of main diagonal is " + FindDiagSum(myArray));
