/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int rows = 4;
int columns = 4;
int[,] matrix = new int[rows, columns];

int count = 0;
int minRows = 0;
int minColumns = 0;
int maxRows = rows - 1;
int maxColumns = columns - 1;

for (int i = 0; i <= maxColumns; i++) 
{
    count++;
    matrix[minRows, i] = count;
}

for (int j = minRows+1; j <=maxRows; j++) 
{
    count++;
    matrix[j, maxColumns] = count;
}

for (int i = maxColumns-1; i >= 0; i--) 
{
    count++;
    matrix[maxRows, i] = count;
}

for (int j = maxRows-1; j > minRows; j--) 
{
    count++;
    matrix[j, minColumns] = count;
}

for (int i = minColumns+1; i < maxColumns; i++) 
{
    count++;
    matrix[minRows+1, i] = count;
}
for (int j = minRows+2; j < maxRows; j++) 
{
    count++;
    matrix[j, maxColumns-1] = count;
}

for (int i = maxColumns-2; i > 0; i--) 
{
    count++;
    matrix[maxRows-1, i] = count;
}
   

WriteMatrix(matrix);

void WriteMatrix(int[,] array)  
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write("0" + array[i, j]+ " ");
            else
                Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
