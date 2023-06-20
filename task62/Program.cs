// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

int[,] GetMass()
{
    int[,] massive = new int[4,4];
    int count=0;
    int c=1;
    int col=massive.GetLength(1);
    int rows=massive.GetLength(0);
    while(c<17){
        for(int i=count;i<col;i++)
        {
            massive[count,i]=c;
            c++;
        }
        
        for(int j=1+count;j<rows;j++)
        {
            massive[j,col-1]=c;
            c++;
        
        }
        for(int i=col-2;i>=count;i--)
        {
            massive[rows-1,i]=c;
            c++;
        }
        for(int i=rows-2;i>=(count+1);i--)
        {
            massive[i,count]=c;
            c++;
        }
        count++;
        rows--;
        col--;
        
        }
    return massive;
}


void PrintArray(int[, ] mass)
{
for(int i=0; i<mass.GetLength(0) ;i++)
{for(int j=0;j<mass.GetLength(1) ;j++)
Console.Write(""+mass[i,j]+" ") ;
Console.WriteLine() ;
}

}

PrintArray(GetMass());
