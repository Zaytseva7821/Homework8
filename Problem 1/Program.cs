// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Номер строки с наименьшей суммой элементов: 1 строка
// (допускается указывать индекс строки в массиве, в данном примере - 0)

int DataEntry(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] Matrix)
{
    System.Console.WriteLine("Ваш массив:");
    for(int i = 0; i < Matrix.GetLength(0); i++)
    {
        for(int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = new Random().Next(-999,999);
            System.Console.Write($"{Matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }

}

void FindStringWithMinSum(int[,] Matrix)
{
    int min = 1000*Matrix.GetLength(0); //1000 потому что максимальное число в рандоме - 999
    int iMin = -1;
    for(int i = 0; i < Matrix.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < Matrix.GetLength(1); j++)
        {
            sum += Matrix[i,j];
        }
        if (sum < min)
        {
            min = sum;
            iMin= i+1;
        }
    }
    System.Console.WriteLine($"Наименьшая сумма элементов {min} в {iMin} строке");
}

int m = DataEntry("Сколько строк будет в вашем массиве?");
int n = DataEntry("Сколько столбцов будет в вашем массиве?");
int [,] array = new int [m, n];
FillMatrix(array);