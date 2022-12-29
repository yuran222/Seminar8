//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7


// int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)  
// {                                                                           
//   int[,] newArray = new int[rows, columns];  

//   for (int i = 0; i < rows; i++)
//   {
//      for(int j = 0; j < columns; j++)
//      {
//        newArray[i,j] = new Random().Next(minValue,maxValue + 1);
//      }
//   }
//   return newArray;    
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0;i < array.GetLength(0) ;i++ ) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)  
//         {
//            Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine(); 
//     }
// }

// int[,] ChangeRows (int[,] array,int row1, int row2)
// {
//     if(row1 >= array.GetLength(0) || row2 >= array.GetLength(0))  
//     return array;                                                 
//     else                                       
//     for(int j = 0 ; j < array.GetLength(1); j++)
//     {
//         int temp = array[row1,j];
//         array[row1,j] = array[row2,j];
//         array[row2,j] = temp;
//     }
//     return array;
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер первой строки которую хотите поменять ");
// int r1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер второй строки которую хотите поменять ");
// int r2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2DArray(m,n,min,max);

// Show2DArray(myArray);

// Console.WriteLine();
// ChangeRows(myArray,r1,r2);

// Show2DArray(myArray);


// int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] RowsToColumns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//         return array;
//     else
//     {
//         for (int i = 0; i < array.GetLength(0)-1; i++)
//         {
//             for (int j = i + 1; j < array.GetLength(0); j++)
//             {
//                 int temp = array[i,j];
//                 array[i,j] = array[j,i];
//                 array[j,i] = temp;
//             }
//         }
//     }
//     return array;
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2DArray(m,n,min,max);
// Show2DArray(myArray);
// myArray = RowsToColumns(myArray);
// Console.WriteLine();
// Show2DArray(myArray);


//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Min (int[,] array)
{
    int min = array[0,0];
    int MinRow = 0;
    int MinColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array [i, j] <= min)
            {
                min = array [i, j];
                MinRow = i;
                MinColumn = j;
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i,MinColumn] = 0;
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[MinRow,j] = 0;
    }
    return array;
}

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m,n,min,max);
Show2DArray(myArray);
Min(myArray);
Console.WriteLine();
Show2DArray(myArray);
