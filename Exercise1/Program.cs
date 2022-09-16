// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myarray = new int[rows, columns];

FillArray(myarray);
PrintArray(myarray);
Console.WriteLine();
PrintArray(SortArray(myarray));

void FillArray(int[,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
          for (int j = 0; j < array.GetLength(1); j++)
          {
                    array[i, j] = Convert.ToInt32(new Random().Next(0, 100)) / 10;
          }
     }
 }

void PrintArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
     {
     Console.Write("[ ");
     for (int j = 0; j < array.GetLength(1); j++)
    {
           Console.Write(array[i, j] + " ");
    }
     Console.Write("]");
     Console.WriteLine("");
     }
}

int[,] SortArray(int[,] array)
{
   int temp = 0;
   for(int n = 0; n < array.GetLength(1); n++)
   {
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1) - 1; j++)
		{
			if (array[i, j] < array[i, j + 1])
			{
				temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
				
			}
		}
	}
   }return array;
}