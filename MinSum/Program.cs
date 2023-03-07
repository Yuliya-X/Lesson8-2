// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// подзадачи: задать размер руками, создать, заполнить, напечатать массив, 
// вычислить сумму элеметнов строки, опредедлить миниальное значение, напечатать 

int Input(string msg)
{
  bool flag = false;
  int value = 0;
  while (!flag)  
  {
    Console.Write(msg + " ");
    flag = int.TryParse(Console.ReadLine(), out value);
  }
  return value;
}

int[,] CreateArray(int m, int n) => new int[m, n];

void FillMatrix(int[,] mat, int min = 0, int max = 10)
{
  int row = mat.GetLength(0);
  int columns = mat.GetLength(1);
  
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        mat[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintMatrix(int [,] mat)
{
  int row = mat.GetLength(0);
  int columns = mat.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        Console.Write($"{mat[i, j], 3} ");
        }
    Console.WriteLine();
    }
}

int FindMinSum(int[,] mat)
{
    int row = mat.GetLength(0);
    int columns = mat.GetLength(1);
    int minSum = int.MaxValue;
    int index = 0;
    for (int i = 0; i < row; i++)
    {
        int temp = 0;
        for (int j = 0; j < columns; j++)
        {
            temp += mat[i, j];
        }
        Console.Write(temp + "; ");
        if (temp < minSum)
        {
            minSum = temp;
            index = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Cтрокa с наименьшей суммой: " + index);
    return index;
}

int rows = Input("Введите количество строк: ");
int columns = Input("Введите количество столбцов: ");
int [,] matrix = new int [rows, columns];
CreateArray(rows, columns);
FillMatrix(matrix);
PrintMatrix(matrix);
Console.Write("Суммы строк: ");
FindMinSum(matrix);
//PrintMatrix(matrix);
