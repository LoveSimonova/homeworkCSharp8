// See https://aka.ms/new-console-template for more information
int GetRows()
{
    Console.WriteLine("Введите количество строк: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetColumns()
{
    Console.WriteLine("Введите количество столбцов: ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetMass(int rows, int columns)
{
    double[,] massive = new double[rows,columns];
    Random rnd = new Random();
    for(int i=0;i<rows;i++)
    {
        for(int j=0;j<columns;j++)
        {
            massive[i,j]=rnd.NextDouble();
            Console.Write($"    "+ massive[i,j]);
        }
        Console.WriteLine();
    }
    return massive;
}

double[,]  GetMaxToMinRows(double[,] massive)
{
   
    for (int i=0;i<massive.GetLength(0);i++)
    {
    for(int j=0;j<massive.GetLength(1);j++)
       {
        for(int count=0;count<massive.GetLength(1);count++)
            { if(massive[i,count]<massive[i,j])
            {double temp=massive[i, j];
            massive  [i, j]=massive  [i,count];
        massive[i, count]=temp;
        }
        }
    }
    
}
return massive;
}

void PrintArray(double[, ] mass)
{
for(int i=0; i<mass.GetLength(0) ;i++)
{for(int j=0;j<mass.GetLength(1) ;j++)
Console.Write(""+mass[i,j]+" ") ;
Console.WriteLine() ;
}

}

int m=GetRows();
int n=GetColumns();
PrintArray(GetMaxToMinRows(GetMass(m,n)));