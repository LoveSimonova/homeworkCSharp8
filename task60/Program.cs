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

int GetHeight()
{
    Console.WriteLine("Введите 3-е число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GetMass(int rows, int columns,int height)
{
    int[,,] massive = new int[rows,columns,height];
    int[] formas = new int[rows*columns*height];
    int count=0;
    Random rnd = new Random();
    bool equal=false;
    for(int i=0;i<rows;i++)
    for(int j=0;j<columns;j++)
    {
        for(int z=0;z<height;z++)
        {
            int num=rnd.Next(10,99);
            if(count!=0)
                for(int k=0;k<count;k++)
                    if(num==formas[k])
                    {
                        equal=true;
                    }           
            if(equal)
            {
                if(z>0)
                    z--;
                else
                {
                    if(j>0)
                        j--;
                    else
                        i--;
                }
                equal=false;
            }
            else
            {
                formas[count]=num;
                count++;                     
                massive[i,j,z]=num;
            }
            //Console.WriteLine(""+count+" "+i+" "+j+" "+z);

        }
        //Console.WriteLine();
    }
    return massive;
}



void PrintArray(int[,, ] mass)
{
    for(int z=0;z<mass.GetLength(2);z++)
        for(int i=0;i<mass.GetLength(0);i++)
        {
            for(int j=0;j<mass.GetLength(1);j++)
                Console.Write(""+mass[i,j,z]+"("+i+","+j+","+z+")  ");
            Console.WriteLine();
        }
}

int m=GetRows();
int n=GetColumns();
int z=GetHeight();
PrintArray(GetMass(m,n,z));