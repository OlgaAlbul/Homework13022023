// Показать двумерный массив размером m×n заполненный вещественными числами
void PrintArray(double[,] matr)       
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"\t {matr[i,j]} ");
        }
        Console.WriteLine(" ");
    }
}

void FillArray(double[,] matr)         
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=rnd.Next(0, 100) + rnd.NextDouble();

        }
    }
}
Console.WriteLine("Enter the number of rows"!);
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of colomns"!);
int n = int.Parse(Console.ReadLine());

double[,] matrix = new double[m,n];      
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);