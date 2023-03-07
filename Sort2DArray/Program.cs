// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// подзадачи: задать размер руками, создать, заполнить, напечатать массив, отсортировать, напечатать 

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

void GetSort(int [,] mat)
{
int row = mat.GetLength(0);
int columns = mat.GetLength(1);
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < columns; j++)
        {
        for (int mesto = 0; mesto < columns - 1; mesto++)
            {
            if (mat[i, mesto] < mat[i, mesto + 1])
                {
                int temp = mat[i, mesto + 1];
                mat[i, mesto + 1] = mat[i, mesto];
                mat[i, mesto] = temp;
                }
            }
        }
    }
Console.WriteLine();
}

int rows = Input("Введите количество строк: ");
int columns = Input("Введите количество столбцов: ");
int [,] matrix = new int [rows, columns];
CreateArray(rows, columns);
FillMatrix(matrix);
PrintMatrix(matrix);
GetSort(matrix);
PrintMatrix(matrix);
