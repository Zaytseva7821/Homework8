// Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34

int DataEntry(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetNewValue(int[,] array, int CurrentElement)
{
    int value = new Random().Next(0,51);
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            while (value == array[i,j]) 
            {
                value = GetNewValue(array, CurrentElement);
            }
        }
    }
    return value;
}

void FillVariousMatrix(int[,] Matrix)
{
    int current = 0;
    System.Console.WriteLine("Ваша матрица:");
    for(int i = 0; i < Matrix.GetLength(0); i++)
    {
        for(int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = GetNewValue(Matrix, current);
            current++;
            System.Console.Write($"{Matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }

}


int m = DataEntry("Сколько строк будет в вашем массиве?");
int n = DataEntry("Сколько столбцов будет в вашем массиве?");
int [,] array = new int [m, n];
FillVariousMatrix(array);

