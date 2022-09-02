/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

System.Console.Clear();

int[,,] FillingArray(int rows,int colomns, int thirdDimension)
{
    int[,,] array = new int[rows, colomns, thirdDimension];

    int numbers =10;
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {           
            for (int t = 0; t < array.GetLength(2); t++)
            {
                numbers += 2;
                array[i,j,t] += numbers;
            }
        }
    }
    return array;
}

void PrintFillingArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = 0; t < array.GetLength(2); t++)
            {
                System.Console.Write($"{array[i,j,t]}  {i},{j},{t}   ");
            }
        }
        System.Console.WriteLine();
    }
}

int[,,] array = FillingArray(2,2,2);

PrintFillingArray(array);