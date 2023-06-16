// _____________________Домашняя работа______________________________________________-
// _________________________Задание 1___________________________

//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


//   Console.WriteLine("Введите кол-во строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int colomns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double[rows,colomns];

// void FillingArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(-99,100) / 10.0;
//         }
//     }
// }


// void PrintArray(double[,] array)
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
// FillingArray(matrix);
// PrintArray(matrix);



// _______________-Задание 2__________________________________
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// 

// Console.WriteLine("Введите кол-во строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int[rows,colomns];

// void FillingArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(1,10);
//         }
//     }
// }


// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void SearchElementArray()
// {
//     Console.WriteLine("Введите нужную строку");
//     int rows2 = Convert.ToInt32(Console.ReadLine());
    
//     Console.WriteLine("Введите нужную cтолбец");
//     int colomns2 = Convert.ToInt32(Console.ReadLine());
//      for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if ((rows2 > rows) || (colomns2 > colomns))
//             {
//                 Console.WriteLine($"такого числа нет");
//                 break;              
//             }
//             else
//             {
//                 Console.WriteLine(matrix[rows2,colomns2]);
//                 break;
//             }
//         }
//     }
//     Console.WriteLine();
// }
// FillingArray();
// PrintArray();
// Console.WriteLine();
// SearchElementArray();





// _____________________________________-Задание 3______________________________________
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.WriteLine("Введите кол-во строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int[rows,colomns];

// void FillingArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(1,10);
//         }
//     }
// }


// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void SearchAverageArray()
// {
// Console.WriteLine("_________________");
// int countRows = matrix.GetLength(0);
// int countColomns = matrix.GetLength(1);
// for (int i = 0; i < countColomns; i++)
// {
//     double sum = 0;
//     double average = 0;
//     for (int j = 0; j < countRows; j++)
//     {
//         sum += matrix[i,j];
//     }
//    average = sum / countRows;
//    Console.WriteLine("Среднее арифметическое столбца {0}: {1}", i + 1, average);
// }  
// }

// FillingArray();
// PrintArray();
// SearchAverageArray();




