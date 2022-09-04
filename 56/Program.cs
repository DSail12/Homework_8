// Задача 56.
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine($"\nВведите пожалуйста размер прямоугольного массива (a x b): ");
int a = InputNumbers ("Введите пожалуйста a: ");
int b = InputNumbers ("Введите пожалуйста b: ");
int range = InputNumbers ("Введите пожалуйста диапазон значений элементов массива: от 1 до ");

int[,] array = new int [a, b];
CreateArray(array);
WriteArray(array);

int MinSumLine = 0;
int SumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int TempSumLine = SumLineElements(array, i);
    if (SumLine > TempSumLine)
    {
        SumLine = TempSumLine;
        MinSumLine = i;
    }
}

Console.WriteLine($"\n{MinSumLine + 1} - строка с наименьшей суммой ({SumLine}) элементов.");

int SumLineElements(int[,] array, int i)
{
    int SumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        SumLine += array[i, j];
    }
    return SumLine;
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
            array[i, j] = new Random().Next(range);
        }
    }
}
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}