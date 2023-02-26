//Составить частотный словарь элементов двумерного массива
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
void CountElement(int[,] array)
{
    int[] count = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)
        {
            count[array[i, j]] += 1;
        }
    for (int i = 0; i < count.Length; i++)
    {
        if (count[i] > 0)
            Console.WriteLine($"{i} встречается {count[i]} раз");
    }
}
Console.Write("Введите количество строк двумерного массива: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
CountElement(array);