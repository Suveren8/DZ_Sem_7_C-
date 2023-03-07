// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] FillMatrix ()
{
  int rowIn = 5;
  int collIn = 5;
  int [,] resultMatrix = new int [rowIn, collIn];
  Random rnd = new Random();
  for (int i = 0; i < rowIn; i++)
  {
    for (int j = 0; j < collIn; j++)
    {
      resultMatrix [i,j] = rnd.Next(1,10);
    }
  }
  return resultMatrix;
}

void ShowRealMatrix (int [,] matrixIn)
{
  System.Console.WriteLine("Матрица заполнена случайными целыми числами:");
  for (int i = 0; i < matrixIn.GetLength(0); i++)
  {
    for (int j = 0; j < matrixIn.GetLength(1); j++)
    {
      System.Console.Write($"{matrixIn[i,j]}\t");
    }
    System.Console.WriteLine();
  }
}

double [] AverageFillMatrix (int [,] matrixIn)
{
  double [] sumOfColummns = new double [matrixIn.GetLength(1)];
  for (int i = 0; i < matrixIn.GetLength(0); i++)
  {
    for (int j = 0; j < matrixIn.GetLength(1); j++)
    {
      sumOfColummns[j] += (double) matrixIn [i,j];
    }
  }
  for (int i = 0; i < sumOfColummns.Length; i++)
  {
    sumOfColummns[i] /= sumOfColummns.Length;
  }
  return sumOfColummns;
}

void ShowAverageColumnMatrix (double [] arrayIn)
{
  System.Console.WriteLine("Значения среднего арифметического столбцов матрицы: ");
  for (int i = 0; i < arrayIn.Length; i++)
  {
    System.Console.Write($"{arrayIn[i]}\t");
   }
}

void SearchAverageColumnsMatrix ()
{
  int [,] useMatrix = FillMatrix();
  ShowRealMatrix (useMatrix);
  double [] averageArray = AverageFillMatrix (useMatrix);
  ShowAverageColumnMatrix (averageArray);
}

SearchAverageColumnsMatrix ();
