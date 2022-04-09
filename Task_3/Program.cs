// Показать двумерный массив размером m×n заполненный целыми числами
// В двумерном массиве n×k заменить четные элементы на противоположные
// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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

void ChangeChetElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j]%2 == 0)
            matr[i,j] *= (-1);
        }
}

void ChangeChetIndexElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i += 2)
        for (int j = 0; j < matr.GetLength(1); j += 2)
        {
            matr[i,j] *= matr[i,j];
        }
}

int[,] matrix1 = new int[5, 6];
FillMatrix(matrix1);
PrintMatrix(matrix1);

ChangeChetElements(matrix1);
PrintMatrix(matrix1);

int[,] matrix2 = new int[5, 6];
FillMatrix(matrix2);
PrintMatrix(matrix2);

ChangeChetIndexElements(matrix2);
PrintMatrix(matrix2);