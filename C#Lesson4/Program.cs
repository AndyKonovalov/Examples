//string [,] table = new string [2, 5];
// table [0, 0]     table [0, 1]    table [0, 2]    table [0, 3]    table [0, 4]| 
// table [1, 0]     table [1, 1]    table [1, 2]    table [1, 3]    table [1, 4]|\
//                                  ____________    ____________                  \
//                                            \          /                         \  
//                                             \        /                           \ 
//                                              \      /                             \
//                                               \    /                               \
//                          индексы столбцовот 0 до 4, потому что       индексы строк от 0 до 1
//                          что 5 столбцов в массиве                    потому что 2 строки в массиве

// string[,] table = new string[2, 5];
// table[1, 2] = "Word";

// for (int rows = 0; rows < 2; rows++) // rows -> строки
// {
//     for (int columns = 0; columns < 5; columns++) // columns -> столбцы
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }
// void PrintArray(int[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matrix.GetLength(1); columns++)
//         {
//             Console.Write($"{matrix[rows, columns]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matrix.GetLength(1); columns++)
//         {
//             matrix[rows, columns] = new Random().Next(1, 10); // [0, 10)
//         }
//     }
// }

// int[,] matrix = new int[3, 4];

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// Рисуем "большой палец вверх"

// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// };
// // 0 - закрашенный пиксель
// // 1 - незакрашенный пиксель
// void PrintImage(int[,] image)
// {
//     for (int rows = 0; rows < image.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < image.GetLength(1); columns++)
//         {
//             //Console.Write($"{image[rows, columns]} ");
//             if (image[rows, columns] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int rows, int columns)
// {
//     if (pic[rows, columns] == 0)
//     {
//         pic[rows, columns] = 1;
//         FillImage(rows - 1, columns);
//         FillImage(rows, columns - 1);
//         FillImage(rows + 1, columns);
//         FillImage(rows, columns + 1);
//     }
// }

// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);

// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}"); // 1*2*3 = 6
// }

// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"{i} = {Fibonacci(i)}");
// }