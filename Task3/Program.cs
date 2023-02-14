// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void PrintArray(int[,] matr)       
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

void FillArray(int[,] matr)         
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=rnd.Next(0, 10);

        }
    }
}

void SquaredArray(int[,] matr)         
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           if (i%2==0 && j%2==0)
           {
            matr[i,j]=matr[i,j]*matr[i,j];
           } 

        }
    }
}

Console.WriteLine("Enter the number of rows"!);
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of colomns"!);
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m,n];      
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
SquaredArray(matrix);
PrintArray(matrix);