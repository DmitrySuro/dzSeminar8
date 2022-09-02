/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

System.Console.Clear();

int[,] FirstArrayFilling (int rows, int colomns)
{
    int[,] firstArray = new int[rows,colomns];
    var rand = new Random();
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            firstArray[i,j] = rand.Next(1,10);
        }
    }
    return firstArray;
}

int[,] SecondArrayFilling(int rows, int colomns)
{
    int[,] secondArray = new int[rows,colomns];
    var rand = new Random();
    for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            secondArray[i,j] = rand.Next(1,10);
        }
    }
    return secondArray;
}

int[,] ResultOfMatrixMultiplication(int[,] firstArray,int[,] secondArray,int rows, int colomns)
{
    int[,] matrixMultiplicaton = new int[rows,colomns];
    for (int i = 0; i < matrixMultiplicaton.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMultiplicaton.GetLength(1); j++)
        {
            int sumRowColomns = 0;
            for (int k = 0; k < firstArray.GetLength(0); k++)
            {
                sumRowColomns += firstArray[i,k] * secondArray[k,j];
            }
            matrixMultiplicaton[i,j] = sumRowColomns;
        }
    }
    return matrixMultiplicaton;
}

void PrintFirstArrayFilling(int[,] firstArray)
{
   for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            System.Console.Write(firstArray[i,j] + " ");
        }
    System.Console.WriteLine();
    }
}

void PrintSecondArrayFilling(int[,] secondArray)
{
   for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            System.Console.Write(secondArray[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

void PrintResultOfMatrixMultiplication(int[,] matrixMultiplicaton)
{
    for (int i = 0; i < matrixMultiplicaton.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMultiplicaton.GetLength(1); j++)
        {
            System.Console.Write(matrixMultiplicaton[i,j] + " ");
        }
    System.Console.WriteLine();
    }
}

int[,] firstArray = FirstArrayFilling(3,3);
int[,] secondArray = SecondArrayFilling(3,3);
int[,] matrixMultiplicaton = ResultOfMatrixMultiplication(firstArray,secondArray,3,3);

System.Console.WriteLine("Первая матрица");
PrintFirstArrayFilling(firstArray);
System.Console.WriteLine("Вторая матрица");
PrintSecondArrayFilling(secondArray);
System.Console.WriteLine("Результат перемножения матриц");
PrintResultOfMatrixMultiplication(matrixMultiplicaton);