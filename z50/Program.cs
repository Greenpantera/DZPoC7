
string GetCount(int [,] array, int count)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
       for(int j=0; j<array.GetLength(1); j++)
       {
           if(count==array[i,j])
           {
            return "это число входит в двумерный массив";
           }
         }
    }
    return "это число не входит в двумерный массив";
}


void PrintMassive(int [,] massive)
{
    for(int i=0; i<massive.GetLength(0); i++)
    {
       for(int j=0; j<massive.GetLength(1); j++)
       {
        Console.Write($"{massive[i,j]} ");
       }
       Console.WriteLine();
    }
   }

int [,] DoMassive(int rows, int columns, int minValue, int maxValue)
{
    int [,] result = new int [rows, columns];
    for(int i=0; i<rows; i++)
    {
       for(int j=0; j<columns; j++)
       {
           result[i,j] = new Random().Next(minValue, maxValue+1);
       }
}
return result;
}

int GetInfo (string message)
{
    Console.Write(message);
    int numN = Convert.ToInt32(Console.ReadLine ());
    return numN;
}


int rows = GetInfo("Введите количество строк: ");
int columns = GetInfo("Введите количество столбцов: ");
int count = GetInfo("Введите число: ");
int [,] massive = DoMassive(rows, columns, 0, 9);
PrintMassive(massive);
GetCount(massive, count);
Console.WriteLine($"{GetCount(massive, count)}");