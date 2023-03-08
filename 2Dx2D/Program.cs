// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// подзадачи: задать размер руками, создать, заполнить, напечатать массив 1, 2
// раcсчитать произведение обеих матриц, напечатать 

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

// Алгоритм нахождения произведения матриц: 
// ( a1   b1 ) * ( c1   d1 ) = ( a1*c1 + b1*c2   a1*d1 + b1*d2 )
// ( a2   b2 ) * ( c2   d2 ) = ( a2*c1 + b2*c2   a2*d1 + b2*d2 )
// строка на столбец, как задать??????
// !!!!!!!!!    c[i][j] += X[i][k] * Y[k][j] 


void Matrix2Dx2D(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
  for (int i = 0; i < matrix3.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i, k] * matrix2[k, j]; 
        matrix3[i, j] = sum;
      }
    }
  }
}

int rows = Input("Введите количество строк матриц: ");
int columns = Input("Введите количество столбцов матриц: ");
Console.WriteLine();
int [,] matrix1 = new int [rows, columns];
int [,] matrix2 = new int [rows, columns];
int [,] matrix3 = new int [rows, columns];
CreateArray(rows, columns);
CreateArray(rows, columns);
FillMatrix(matrix1);
FillMatrix(matrix2);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Matrix2Dx2D(matrix1, matrix2, matrix3);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
PrintMatrix(matrix3);
