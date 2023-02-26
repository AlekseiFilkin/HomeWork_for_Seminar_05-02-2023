//В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
(int, int) MinElement(int[,] array)
{
    int rowIndex = 0;
    int columnIndex = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                rowIndex = i;
                columnIndex = j;
            }
        }
    }
    return (rowIndex, columnIndex);
}
int[,] RowsColumnnsMinElementDelete(int[,] array, int rowIndex, int columnIndex)
{
    int[,] array2 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != rowIndex)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != columnIndex)
                {
                    array2[k, l] = array[i, j];
                    l++;
                }
            }
            l = 0;
            k++;
        }
    }
    return array2;
}
Console.Write("Введите количество строк двумерного массива: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
(int rowIndex, int columnIndex) = MinElement(array);
Console.WriteLine($"Минимальный элемент находится в {rowIndex} строке и {columnIndex} столбце.");
int[,] array2 = RowsColumnnsMinElementDelete(array, rowIndex, columnIndex);
PrintArray(array2);