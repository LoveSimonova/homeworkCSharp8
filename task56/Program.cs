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

double[]  GetSums(double[,] massive)
{
    double[] masSum=new double  [massive.GetLength(0)];
    for (int i=0;i<massive.GetLength(0);i++)
    {
    for(int j=0;j<massive.GetLength(1);j++)
       {
        masSum[i]+=massive[i,j];
        }
    }
    return masSum;
}

void PrintMinRow(double[ ] mass)
{
double min=mass[0];
int index=0;
for(int j=0;j<mass.GetLength(0) ;j++)
{
if(min>mass[j])
{
min=mass[j];
index=j;
}
}
Console.WriteLine("Mix Row: "+index) ;
}
int m=GetRows();
int n=GetColumns();
PrintMinRow(GetSums(GetMass(m,n)));