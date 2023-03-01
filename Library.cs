public class Library
{
  // 1 метод описания программы с выводом в терминал
  public static void GetText(string text)
  {
    Console.WriteLine(text);
  }
  // 1.1 метод приглашения к вводу целого числа с терминала
  public static int GetNumber(string text)
  {
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
  }

  // 1.2 метод приглашения к вводу дробного числа с терминала
  public static double GetNumberDouble(string text)
  {
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
  }

  // 2. метод создания массива целых чисел
  public static int[] CreateArray(int size)
  {
    return new int[size];
  }

  // 3. метод записи чисел
  public static string Evennumbers(int N)
  {
    string output = String.Empty;
    int index = 2;
    while (index <= N)
    {
      output = output + index + " ";
      index++;
    }
    return output;
  }

  // 3.1 метод заполнения массива руками
  public static void FillByUser(int[] array)
  {
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
      array[index] = GetNumber("Введите " + index + "элемент: ");
      index++;
    }

  }

  // 3.2 метод заполнения массива рандомно
  public static void FillArrayRandom(int[] collection)
  {
    int size = collection.Length;
    int index = 0;
    while (index < size)
    {
      collection[index] = new Random().Next(0, 10);
      index++;
    }

  }

  // 5. метод печати массива
  public static string Print(int[] array)
  {
    string result = String.Empty;
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
      result = result + " " + array[index];
      index++;
    }
    return result;
  }

  // 6.1 метод создания двухмерного массива строк

  public static void PrintTable(string[,] table)
  {
    for (int rows = 0; rows < table.GetLength(0); rows++)
    {
      for (int columns = 0; columns < table.GetLength(1); columns++)
      {
        Console.Write($"|{table[rows, columns]}|");
      }
      Console.WriteLine();
    }
  }

  // 6.2 метод создания двухмерного массива целых чисел

  public static void PrintMatrix(int[,] matr)
  {
    for (int i = 0; i < matr.GetLength(0); i++)
    {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
        Console.Write($"{matr[i, j]} ");
      }
      Console.WriteLine();
    }
  }
  // 6.3 метод заполнения двухмерного массива рандомно целыми числами
  public static void FillMatrix(int[,] matr)
  {
    for (int i = 0; i < matr.GetLength(0); i++)
    {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
        matr[i, j] = new Random().Next(1, 10);
      }
    }
  }
  // 7 метод отображения "+" вместо чисел за исключением "0" в двухмерном массиве целых чисел
  public static void PrintImage(int[,] image)
  {
    for (int i = 0; i < image.GetLength(0); i++)
    {
      for (int j = 0; j < image.GetLength(1); j++)
      {
        // Console.Write($"{image[i, j]} ");
        if (image[i, j] == 0) Console.Write($" ");
        else Console.Write($" +");
      }
      Console.WriteLine();
    }
  }
  /* // 8. метод закрашивания области массивов  
  
  public static void FillImage(int row, int col)
  {
    if (pic[row, col] == 0)
    {
      pic[row, col] = 1;
    FillImage(row-1, col);
    FillImage(row, col-1);
    FillImage(row+1, col);
    FillImage(row, col+1);
    }
  }*/

  // 9. метод вычисления факториала
  public static double Factorial(int n)
  {
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
  }

}

