// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

// int [,] CreateArray(int row, int col, int min, int max)
// {   
//     int [,] array = new int [row, col];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void OrderedArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int k = 0; k < array.GetLength(1); k++)
//         {
//             for (int j = 0; j < array.GetLength(1)-1; j++)
//             {
//                 if(array[i,j] < array[i,j+1])
//                 {
//                     int temp = array[i,j];
//                     array[i,j] = array[i,j+1];
//                     array[i,j+1] = temp;
//                 }
//             }
//         }
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите количество строк массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число элемента: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число элемента: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array = CreateArray(a, b, min, max);
// PrintArray(array);
// OrderedArray(array);
// PrintArray(array);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// int [,] CreateArray(int row, int col, int min, int max)
// {
//     int [,] array = new int [row, col];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void MinSumElem(int [,] array)
// {
//     int [] arr = new int [array.GetLength(0)];
//     int k = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i,j];
//         }
//         arr[k] = sum;
//         // Console.Write(arr[k] + "; ");
//         k++; 
//     }
//     int imin = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         int min = arr[imin];
//         if(arr[i] < min)
//         {
//             min = arr[i];
//             imin = i;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine((imin + 1) + " строка с наименьшей суммой элементов");
// }

// Console.Write("Введите количество строк массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число элемента: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число элемента: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array = CreateArray(a, b, min, max);
// PrintArray(array);
// MinSumElem(array);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int [,] CreateArray(int row, int col, int min, int max)
// {
//     int [,] array = new int [row, col];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] MatrixMultiplication(int [,] array1, int [,] array2)
// {
//     int [,] newarray = new int [array1.GetLength(0), array2.GetLength(1)];
//     for (int i = 0; i < newarray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newarray.GetLength(1); j++)
//         {
//             for (int k = 0; k < array1.GetLength(1); k++)
//             {
//                 newarray[i,j] += array1[i,k] * array2[k,j];
//             }
//         }
        
//     }
//     return newarray;
// }

// Console.Write("Введите количество строк массива №1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива №1 и строк массива №2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива №2: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число элемента: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число элемента: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array1 = CreateArray(a, b, min, max);
// PrintArray(array1);
// Console.WriteLine();
// int [,] array2 = CreateArray(b, c, min, max);
// PrintArray(array2);
// Console.WriteLine();
// int [,] newarray = MatrixMultiplication(array1, array2);
// PrintArray(newarray);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int [,,] Create3dArray(int row, int col, int level)
// {
//     int [,,] array = new int [row, col, level];
//     int x = 12;
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             for (int k = 0; k < level; k++)
//             {
//                 array[i,j,k] = x;
//                 x += 7;
//             }
//         }
//     }
//     return array;
// }

// void Print3dArray(int [,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            for (int k = 0; k < array.GetLength(2); k++)
//            {
//             Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
//            }
//            Console.WriteLine();
//         }
//     }
// }
// Console.Write("Введите количество строк массива: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество уровней массива: ");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int [,,] array3d = Create3dArray(x, y, z);
// Print3dArray(array3d);



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// int [,] CreateSpiralArray(int [,] array)
// {
//     int x = 1;
//     int i = 0;
//     int j = 0;
//     while(x <= array.GetLength(0) * array.GetLength(1))
//     {
//         array[i,j] = x;
//         x++;

//         if(i <= j + 1 && i + j < array.GetLength(1) - 1) 
//         {
//             j++;
//         }
//         else if(i < j && i + j >= array.GetLength(0) - 1)
//         {
//             i++;
//         }
//         else if(i >= j && i + j > array.GetLength(1) - 1)
//         {
//             j--;
//         }
//         else 
//             i--;
//     }
//     return array;
// }

// void PrintSpiralArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] array = new int [4, 4];
// PrintSpiralArray(CreateSpiralArray(array));