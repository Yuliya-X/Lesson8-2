// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// подзадачи: задать руками по XYZ, создать, заполнить (здесь задать проверку чисел на повторение) 
// - ушло в один метод: создать. заполнить массив, записать в чек, сравнить, 
// если числа равны => new random пока не найдет нужное, напечатать массив с индексами
// если вариантов не находит (задаю диапазон меньше количества элементов), просто висит !!!!!!!



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

void CreateArray(int[,,] mat3D, int min = 10, int max = 18)
{
  int[] num = new int[mat3D.Length];
  int check;
    for (int i = 0; i < num.GetLength(0); i++)
    {
        num[i] = new Random().Next(min, max);
        check = num[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (num[i] == num[j])
                {
                    int index = 0;
                    num[i] = new Random().Next(min, max);
                    j = 0;
                    for (int x = 0; x < mat3D.GetLength(0); x++)
                    { 
                        for (int y = 0; y < mat3D.GetLength(1); y++)
                        {
                            for (int z = 0; z < mat3D.GetLength(2); z++)
                            {
                                mat3D[x, y, z] = num[index];
                                index++;
                            }
                        }
                    }      
                }
            }
        }
    }
}

void PrintMatrix(int [,,] mat)
{
  int x = mat.GetLength(0);
  int y = mat.GetLength(1);
  int z = mat.GetLength(2);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            Console.Write($"{mat[i, j, k], 3} ({i},{j},{k})");
            Console.WriteLine();
        }
    }
}

int x = Input("Введите x: ");
int y = Input("Введите y: ");
int z = Input("Введите z: ");
int [,,] matrix3D = new int [x, y, z];
CreateArray(matrix3D);
Console.WriteLine("Трёхмерный массив: ");
PrintMatrix(matrix3D);