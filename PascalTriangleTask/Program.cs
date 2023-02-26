//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
Console.Write("Введите количество строк треугольника Паскаля: ");
int n = int.Parse(Console.ReadLine() ?? "");
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (i == j || j == 0)
            {
                array[i, j] = 1;
            }
            else if (j > i)
            {
                array[i, j] = 0;
            }
            else if (i != j)
            {
                array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int a = n * 2;
        int N = n / 2 + i;
        while (N < a)
        {
            Console.Write(" ");
            a--;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write(" " + array[i, j]);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = new int[n, n * 2];
FillArray(array);
PrintArray(array);