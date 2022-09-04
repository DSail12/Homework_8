// Задача 58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine($"\nВведите пожалуйста размеры матриц и диапазон случайных значений элементов матриц: ");
int a = InputNumbers("Введите пожалуйста число строк 1-ой матрицы: ");
int b = InputNumbers("Введите пожалуйста число столбцов 1-ой матрицы и строк 2-ой: ");
int c = InputNumbers("Введите пожалуйста число столбцов 2-ой матрицы: ");
int range = InputNumbers("Введите пожалуйста диапазон случайных значений элементов матриц: от 1 до ");

int[,] FirstMatrix = new int [a, b];
CreateArray(FirstMatrix);
Console.WriteLine($"\nМатрица №1: ");
WriteArray(FirstMatrix);

int[,] SecondMatrix = new int [b, c];
CreateArray(SecondMatrix);
Console.WriteLine($"\nМатрица №2: ");
WriteArray(SecondMatrix);

int[,] resultMatrix = new int [a, c];

MultiplyMatrix(FirstMatrix, SecondMatrix, resultMatrix);
Console.WriteLine($"\nРезультирующая матрица: ");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] FirstMatrix, int[,] SecondMatrix, int[,] resultMatrix)
{
    if (FirstMatrix.GetLength(0) != SecondMatrix.GetLength(1))
    {
        Console.WriteLine("Ошибка: Количество столбцов 1-ой матрицы не равно количеству строк 2-ой матрицы.");
    }
    else
    {
        for (int i = 0; i < FirstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < SecondMatrix.GetLength(1); j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < FirstMatrix.GetLength(1); k++)
                {
                    resultMatrix[i, j] += FirstMatrix[i, k] * SecondMatrix[k, j];
                }
            }
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}