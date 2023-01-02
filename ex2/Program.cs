//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// 
//
//на семинаре с преподователем было обговорено изменение условия задания на иное, так как верхнее можно истолковать неоднозначно
//Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает позицию этого элемента или же указание, что такого элемента нет.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 20);
        }
    }
}
int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void FoundNumber(int[,] matr, int number)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            {
                if (matr[i, j] == number)
                {
                    Console.WriteLine($"координаты элемента со значением {number}: {i},{j}");
                }
                else
                {
                    Console.WriteLine("число не найдено");
                    
                }
            }
        }
    }
}

int rows = EnterNumber("введите m: ");
int colums = EnterNumber("введите n: ");
int[,] matrix = new int[rows, colums];
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int number = EnterNumber("введите число: ");
FoundNumber(matrix,number);





