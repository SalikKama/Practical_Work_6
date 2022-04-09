// Показать двумерный массив размером m×n заполненный вещественными числами
void FillMatrix(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++ )
        for(int j = 0; j < matr.GetLength(1); j++ )
            matr[i,j] = new Random().NextDouble() * 10;
}

void PrintMatrix(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++ )
    {
        for(int j = 0; j < matr.GetLength(1); j++ )
            Console.Write("{0,6:F2}", matr[i,j]);
        Console.WriteLine();
    }
}

double[,] matrix = new double[5,6];
FillMatrix(matrix);
PrintMatrix(matrix);