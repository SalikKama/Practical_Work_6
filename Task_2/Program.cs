// Задать двумерный массив следующим правилом: Aₘₙ = m+n

void FillMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++ )
        for(int j = 0; j < matr.GetLength(1); j++ )
            matr[i,j] = i + j;
}

void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++ )
    {
        for(int j = 0; j < matr.GetLength(1); j++ )
            Console.Write(matr[i,j] + " ");
        Console.WriteLine();
    }
}

int[,] matrix = new int[5,6];
FillMatrix(matrix);
PrintMatrix(matrix);