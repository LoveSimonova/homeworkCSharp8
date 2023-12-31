﻿// See https://aka.ms/new-console-template for more information
int GetRows()
{
    Console.WriteLine("Введите количество строк первой матрицы: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetColumns()
{
    Console.WriteLine("Введите количество столбцов первой матрицы: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetRowSecond()
{
    Console.WriteLine("Введите количество строк второй матрицы: ");
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

double[,]  GetProizv(double[,] a,double[,] b)
{
    double[,] masRez=new double  [a.GetLength(0),b.GetLength(1)];
    int count=0;
    for (int i=0;i<a.GetLength(0);i++)
    {
        
        for(int j=0;j<b.GetLength(1);j++)
        {
            while(count<b.GetLength(1))
            {
                masRez[i,j]+=a[i,count]*b[count,j];
                count++;
            }  
            count=0;      
        }
    }
    return masRez;
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
int k = GetRowSecond();
double[, ] a=GetMass(m,n);
double [,] b=GetMass(k,m);
PrintArray(GetProizv(a,b));