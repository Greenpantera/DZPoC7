
void PrintMassive(double [,] massive)
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

double [,] DoMassive(int rows, int columns, int minValue, int maxValue)
{
    double [,] result = new double [rows, columns];
    for(int i=0; i<rows; i++)
    {
       for(int j=0; j<columns; j++)
       {
           result[i,j] = new Random().Next(minValue, maxValue+1);
           result[i,j] = result[i,j]/10;
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
double [,] massive = DoMassive(rows, columns, 0, 99);
PrintMassive(massive);