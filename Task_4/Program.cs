//В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(0, 10);
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write(matr[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintIndexNumber( int[,] matr, int number)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            if (matr[i,j] == number) Console.Write($"Индексы: {i} {j} ");
}

bool FindNumber(int[,] matr, int number)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            if (matr[i,j] == number) return true;
    return false;
}

int[,] matrix = new int[5, 6];
FillMatrix(matrix);
PrintMatrix(matrix);

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()?? "0");
if(FindNumber(matrix, num)) PrintIndexNumber(matrix, num);
else Console.WriteLine("Такого элемента нет");