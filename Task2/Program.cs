//Задать двумерный массив следующим правилом: Aₘₙ = m+n
void FillArray(int[,] matr)         
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=i+j;

        }
    }
}

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

Console.WriteLine("Enter the number of rows"!);
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of colomns"!);
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int [m,n]; 
FillArray(matrix);
PrintArray(matrix);