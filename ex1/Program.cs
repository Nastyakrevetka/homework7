//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j]);
            Console.Write("  ");
        }
        Console.WriteLine();
    }
}
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random rand = new Random();
            matr[i, j] = Math.Round(rand.NextDouble() * 10, +1);

        }
    }
}
int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int rows = EnterNumber("введите m: ");
int colums = EnterNumber("введите n: ");
double[,] matrix = new double[rows, colums];
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);