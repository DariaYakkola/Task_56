Console.Write("Введите количество строк в двумерном пярмоугольном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в двумерном пярмоугольном массиве: ");
int cols = Convert.ToInt32(Console.ReadLine());
if (rows == cols)
{
  Console.WriteLine("Данный массив не является прямоугольным! ");
  return;
}
/// <summary>
/// Метод, который заполняет двумерный массив целыми числами из рандома
/// </summary>
/// <param name="rows">Количество строк в массиве</param>
/// <param name="cols">Количество столбцов в массиве</param>
/// <param name="minValue">Минимальная цифра для рандома</param>
/// <param name="maxValue">Максимальная цифра для рандома</param>
/// <returns>Возвращаем заполненный массив</returns>
int[,] GetMatrix (int rows, int cols, int minValue, int maxValue)
{
  int [,] matrix = new int[rows, cols];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      matrix[i,j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return matrix;
}
/// <summary>
/// Метод, который печатает двумерный массив
/// </summary>
/// <param name="array2D">Двумерный массив целых чисел</param>
void PrintMatrix (int[,] array2D)
{
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      Console.Write(array2D[i,j] + "\t");
    }
    Console.WriteLine();
  }
}
int[,] matrix = GetMatrix(rows, cols, 0, 10);
PrintMatrix(matrix);
int minLine = 0;
int minSumLine = int.MaxValue;
for (int i = 0; i < rows; i++)
{
  int sum = 0;
  for (int j = 0; j < cols; j++)
  {
    sum+=matrix[i,j];
  }
  if (sum < minSumLine)
  {
    minSumLine = sum;
    minLine = i;
  }
}
Console.Write($"{minLine + 1} - строка с минимальной суммой элементов ");
