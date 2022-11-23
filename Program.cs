//Задача 54,56 : Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
//Напишите программу,которая будет находить строку с
// наименьшей суммой элементов.
/*double [,] ArrayGeneration (int lines,int columns,int smallvalue ,int higvalue)
{
double[,] array = new double [lines,columns];
    for(int i=0; i<lines ;i++)
        for(int j=0; j<columns;j++)
        array[i,j]= Math.Round(new Random().Next(smallvalue-1,higvalue) + new Random().NextDouble (),2);
return array;
}
void ArrayDispley(double[,]array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        Console.Write("{0}\t",array[i,j] );
        Console.WriteLine();
    }
}
double [,] SortRowsInDescendingOrder(double [,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            for(int k=j+1;k<array.GetLength(1);k++)
            {
                if (array[i,j]<array[i,k])
                    {
                    double a = array[i,j];array[i,j]=array[i,k];array[i,k]=a;
                    }
            }        
        }
    }
return array;  
}
int RowWithTheSmallestSumOfElements(double [,] array)
{
double [] sum = new double[array.GetLength(0)]; 
    for(int i=0;i<array.GetLength(0);i++)
        {
        sum[i]=0;
        for(int j=0;j<array.GetLength(1);j++)
            sum[i]=Math.Round(sum[i]+array[i,j],2);
            Console.WriteLine($"Сумма элементов {i+1} строки = {sum[i]}");    
        }
double min= sum[0];
int m = 0;
    for (int j=0;j<array.GetLength(0);j++)
    {
        if(sum[j]<min)
        {
            min=sum[j];m=j;
        } 
    }
return m;
}
Console.WriteLine("Задайте,пожалуйста,размерность двумерного массива.");
Console.Write("Количество строк ? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов ? ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте,пожалуйста,диапазон чисел массива.");
Console.Write("Нижняя граница ? ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница ? ");
int b = Convert.ToInt32(Console.ReadLine());
double [,]myarray = ArrayGeneration (m,n,a,b);
Console.WriteLine("Cгенерированный массив:");
ArrayDispley(myarray);
Console.WriteLine("Отсортированный массив:");
ArrayDispley(SortRowsInDescendingOrder(myarray));
int c=RowWithTheSmallestSumOfElements(myarray);
Console.Write($"Наименьшая сумма элементов приходится на {c+1} строку.");
*/
//Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
/*int [,] MatrixInput (int lines,int columns)
{
int [,] array = new int[lines,columns];
Console.WriteLine("Введите элементы матрицы согласно индексам");
    for(int i=0; i<lines ;i++)
        for(int j=0; j<columns;j++)
        {
        Console.Write($"({i},{j})" );
        array[i,j] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        }    
return array;
}*/
 void ArrayDisp(int[,]array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        Console.Write("{0}\t",array[i,j] );//"{0}\t"- чтобы ровнее было
        Console.WriteLine();
    }
}
/*int [,] ProductOfTwoMatrices(int [,]array1,int [,]array2)
{
    int[,] pro = new int [array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                pro[i, j] = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                    pro[i, j] += array1[i, k] * array2[k, j];
            }
        }
return pro;
}
Console.WriteLine("Задайте,пожалуйста,размерность 1 матрицы");
Console.Write("Количество строк ? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов ? ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myarray1 = MatrixInput(m,n);
Console.WriteLine("Задайте,пожалуйста,размерность 2 матрицы");
Console.Write("Количество строк ? ");
int m1 = Convert.ToInt32(Console.ReadLine());
if (n!=m1)
{
Console.Write("Умножение невозможно! Количество столбцов первой матрицы");
Console.Write("не равно количеству строк второй матрицы.");
}
Console.Write("Количество столбцов ? ");
int n1 = Convert.ToInt32(Console.ReadLine());
int[,] myarray2 = MatrixInput(m1,n1);
ArrayDisp(myarray1);
Console.WriteLine();
ArrayDisp(myarray2);
Console.WriteLine("произведение первой матрицы на вторую");
ArrayDisp(ProductOfTwoMatrices(myarray1,myarray2));
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных 
//чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента в странном виде :).
//Массив размером 2 x 2 x 2
/*
void ArrayGener (int counti,int countj, int countk, int smallvalue, int higvalue)
{
int[,,] array = new int [counti,countj,countk];
    for(int k=0; k<countk;k++)
    {
        for(int i=0; i<counti ;i++)
        {
            for (int j=0; j<countj;j++)
            {
            array[i,j,k]= new Random().Next(smallvalue,higvalue+1);
            Console.Write($"{array[i,j,k]} ({i},{j},{k})   ");
            }
        Console.WriteLine();
        }
    }                                                                                        
}
Console.WriteLine("Задайте,пожалуйста,размерность массива");
Console.Write("размерность i ? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("размерность j ? ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("размерность k ? ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте,пожалуйста,диапазон чисел массива.");
Console.Write("Нижняя граница ? ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница ? ");
int b = Convert.ToInt32(Console.ReadLine());
ArrayGener (m,n,l,a,b);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] Spiral(int a,int m,int n)
{ 
int[,]array = new int [m,n];
for (int k=0,l=m-1,f=n-1; a<=m*n; k++,l--,f--)
{  
    for (int j=k; j<=f; j++)
        {array[k,j]= a;a++;}
    for (int i=k+1; i<=l; i++)
        {
            if(a<=m*n)
                {array[i,f]=a;a++;}
        }
    for (int j=f-1; j>=m-l-1;j--)
        {
            if(a<=m*n)
                {array[l,j]=a;a++;}
        }
    for (int i=l-1;i>=n-f;i--)
        {
            if(a<=m*n)
                {array[i,k]=a;a++;}
        }
}        
return (array);        
}
Console.WriteLine("Задайте,пожалуйста,размерность массива");
Console.Write("количество строк ? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("количество столбцов ? ");
int n = Convert.ToInt32(Console.ReadLine());
int a=1;
ArrayDisp(Spiral(a,m,n));





