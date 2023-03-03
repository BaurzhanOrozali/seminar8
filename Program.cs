// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
int[,] Fill2DArray(int rows, int columns)
{
    Console.Write("\nInput min value = ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nInput max value = ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"  {matr[i, j]}  " + "\t");
        Console.WriteLine();
    }

}

void ReversRankeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if (array[i, z] < array[i, z + 1])
                {
                    int temp = array[i, z + 1];
                    array[i, z + 1] = array[i, z];
                    array[i, z] = temp;
                }
            }
        }
    }
}


Console.Write("\nInput rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("\nInput columns = ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = Fill2DArray(rows, columns);

PrintArray(matrix);
ReversRankeArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/
//----------------------------------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
/*
int [,] Fill2DArray ( int rows, int columns)
{
    Console.WriteLine("Input min value = ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max value = ");
    int maxValue = Convert.ToInt32(Console.ReadLine()); 
    int [,] array = new int [rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array [i, j] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int [,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
            Console.Write($"  {matr[i,j]}  ");
    Console.WriteLine();
    }

}

int SummaNumberLine ( int [,] Array, int j)
{
    int summa = 0;
    for (int i =0; i < Array.GetLength(1); i++)
        summa += Array[j, i];
    return summa;
}


Console.WriteLine("Input rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input columns = ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = Fill2DArray(rows, columns);
 
PrintArray(matrix);

int minimum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if ((SummaNumberLine (matrix, minimum)) > (SummaNumberLine (matrix, i)))
        {
            minimum =i;
        }
    }
Console.Write("номер строки с наименьшей суммой элементов: " + (minimum+1) + " строка.");

*/


// --------------------------------------------------------------------------------------------------

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
int [,] Fill2DArray ( int rows, int columns)
{
    Console.Write("Input min value = ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max value = ");
    int maxValue = Convert.ToInt32(Console.ReadLine()); 
    int [,] array = new int [rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array [i, j] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int [,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
            Console.Write($"  {matr[i,j]}  ");
    Console.WriteLine();
    }
    Console.WriteLine( );

}

Console.Write("Input rows matrix 1 = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns matrix 1 = ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = Fill2DArray(rows, columns);

Console.Write("Input rows matrix 2 = ");
rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns matrix 2 = ");
columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = Fill2DArray(rows, columns);

int [,] CompositionMatrix ( int [,] matr1, int [,] matr2)
{
    int[,] CompositMatrix = new int [rows, columns];   
    for(int i=0; i<matr1.GetLength(0); i++)
    {
        for(int j=0; j<matr1.GetLength(0); j++)
        {
            int sum = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                sum += matr1[i,k] * matr2[k,j];
            }
            CompositMatrix[i,j] = sum;
        }
    }
    return CompositMatrix;    
} 

Console.WriteLine(" ");
Console.WriteLine ("Result one matrix: ");
PrintArray(matrix1);
Console.WriteLine ("Result second matrix: ");
PrintArray(matrix2);
Console.WriteLine ("Result composition matrix: ");
PrintArray(CompositionMatrix ( matrix1, matrix2));
*/

//-------------------------------------------------------------------------------------------------------
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*

int[,,] Fill3DArray()
{
    Console.Write("Input rows matrix  = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns matrix = ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input three matrix = ");
    int three = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Input min value = ");
    // int minValue = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Input max value = ");
    // int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[rows, columns, three];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int z = 0; z < array.GetLength(2); z++)
                array[i, j, z] = new Random().Next(10, 100);
    }
    return array;
}

void PrintArray3D(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int z = 0; z < matr.GetLength(2); z++)
            {
                Console.Write($"  {matr[i, j, z]} " + (i, j, z));
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix3D = Fill3DArray();
PrintArray3D(matrix3D);
*/


//-------------------------------------------------------------------------------------------------------

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
int y =4;
int[,] array = new int[y, y];

int i = 0;
int j = 0;
int k = 1;
while (k <= y * y)
{
    array[i, j] = k;
    if (i <= j + 1 && i + j < y-1)
        ++j;
    else if (i < j && i + j >= y - 1)
        ++i;
    else if (i >= j && i + j > y - 1)
        --j;
    else
        --i;
    ++k;
}
PrintImage(array);
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"  {image[i, j]}  " + " " + "\t");
        }
        Console.WriteLine();
    }
}
*/
