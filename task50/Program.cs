// Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillMatrixWithRandom(int row, int column)
{
  int[,] matrix = new int[row, column];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(0, 100);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
}

void SearchNumber(int[,] matr, int getNumber)
{
  bool get = true;
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (getNumber == matr[i, j])
      {
        get = false;
        break;
      }
    }
  }
  if (get)
  {
    System.Console.Write($" {getNumber} отсутствует в массиве ");
  }
  else
  {
    System.Console.Write($" {getNumber} имеется в массиве ");
  }

}

void SearchIndex(int[,] matr, int getIndex1, int getIndex2)
{
  bool get = true;
  var num = 0;
  if (getIndex1 <= matr.GetLength(0) && getIndex2 <=matr.GetLength(1))
  {
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (matr[i, j] == matr[getIndex1, getIndex2])
      {
        get = false;
        num = matr[i, j];
      }
    }
  }
  if (get)
  {
    System.Console.Write(" По заданому адресу ничего нет ");
  }
  else
  {
    System.Console.WriteLine($" По заданому адресу имеется следующие число: {num} ");
  }
  }
  else
  {
    System.Console.Write(" Поисковые индексы выходят за границы массива!");
  }
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);

System.Console.WriteLine("Чтобы искать по индексу элемента, введите 1");
System.Console.WriteLine("Чтобы искать по значению элемента, введите 2");
int swit = Convert.ToInt32(Console.ReadLine());

switch (swit)
{
  case 1:
    System.Console.Write("Введите первый индекс: ");
    int index1 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите второй индекс: ");
    int index2 = Convert.ToInt32(Console.ReadLine());
    SearchIndex(matrix, index1, index2);
    break;
  
  case 2:
    System.Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    SearchNumber(matrix, number);
    break;
  
  default:
    System.Console.WriteLine("Неверный ввод!");
    System.Console.Write("Введите число 1 или 2");
    break;
}
