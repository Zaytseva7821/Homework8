// Задайте две квадратные матрицы одного размера. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Произведением двух матриц А и В называется матрица С, элемент которой, 
// находящийся на пересечении i -й строки и j -го столбца, равен сумме произведений элементов 
// i -й строки матрицы А на соответствующие (по порядку) элементы j -го столбца матрицы В. 
// Из этого определения следует формула элемента матрицы C: Произведение матрицы А на матрицу В обозначается АВ.

int DataEntry(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] Matrix)
{
    System.Console.WriteLine("Ваша матрица:");
    for(int i = 0; i < Matrix.GetLength(0); i++)
    {
        for(int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = new Random().Next(0,10);
            System.Console.Write($"{Matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }

}

void FindMatrixProduct(int[,] Matrix1, int[,] Matrix2)
{
    int[,] Matrix3 = new int [Matrix1.GetLength(0), Matrix2.GetLength(1)];
    for(int i = 0; i < Matrix3.GetLength(0); i++)
        {
            for(int j = 0; j < Matrix3.GetLength(1); j++)
            {
                for(int k = 0; k < Matrix1.GetLength(1); k++)
                {
                    Matrix3[i,j] += Matrix1[i,k]*Matrix2[k,j];
                }
                System.Console.Write($"{Matrix3[i,j]} " );
            }
            System.Console.WriteLine();
        }
}

int n = DataEntry("Сколько строк и столбцов будет в ваших матрицах?");
int[,] arrayA = new int [n, n];
FillMatrix(arrayA);
int[,] arrayB = new int [n, n];
FillMatrix(arrayB);
System.Console.WriteLine("Произведение ваших матриц:");
FindMatrixProduct(arrayA,arrayB);