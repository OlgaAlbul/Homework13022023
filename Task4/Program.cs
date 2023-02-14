// Написать программу, которая обменивает элементы первой строки и последней строки

void FillArray(int[,] matr)         
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.Next(0, 100);

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

void ChangeRows(int[,] matr)       
{
    int i=0;
    int number = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
        {
            number=matr[i,j];
            matr[i,j]=matr[(matr.GetLength(0)-1),j];
            matr[(matr.GetLength(0)-1),j]=number;
        }  
    
}

Console.WriteLine("Enter the number of rows"!);
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of colomns"!);
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int [m,n]; 
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeRows(matrix);
PrintArray(matrix);
