/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

System.Console.Clear();

int[,] FillingArray(int rows, int colomns)
{
    int[,] array = new int[rows,colomns];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(1,10);
        }
    }
    return array;
}

void PrintFillingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
    System.Console.WriteLine();
    }
}

void SumRowsInArray(int[,] array,int minSumRows)
{
    int rows = 0;
   

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if (minSumRows  > sum)
            {
                minSumRows = sum;
                rows = i;   
            }
                
    }
    System.Console.WriteLine(rows);
    System.Console.WriteLine(minSumRows);
}


int[,] array = FillingArray(4,5);

int minSumRows = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSumRows += array[0,j];
    }
PrintFillingArray(array);
SumRowsInArray(array,minSumRows);