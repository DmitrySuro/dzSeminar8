/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
            array[i,j] = rand.Next(1,150);
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

void SortedDescendingArray(int[,] array,int rows, int colomns)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(1) -1; k++)
            {
                if (array[i,k] < array[i,k + 1])
                {
                    int temp = array[i,k];
                    array[i,k] = array[i,k + 1];
                    array[i,k + 1] = temp;
                }
            }
        }
    }
    
}

int[,] array = FillingArray(4,4);

System.Console.WriteLine("Первоначальный массив");
PrintFillingArray(array);
System.Console.WriteLine("Упорядоченный массив по убыванию");
SortedDescendingArray(array,4,4);
PrintFillingArray(array);
