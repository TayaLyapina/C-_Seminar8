/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int firstMatrixRows = ReadInt("Введите количество строк первой матрицы: ");
int firstMatrixColumns = ReadInt("Введите количество столбцов первой матрицы: ");
int secondMatrixRows = ReadInt("Введите количество строк второй матрицы: ");
int secondMatrixColumns = ReadInt("Введите количество столбцов второй матрицы: ");

if( firstMatrixColumns == secondMatrixRows)
{
    int[,] matrix1 = new int[firstMatrixRows, firstMatrixColumns];
    int[,] matrix2 = new int[secondMatrixRows, secondMatrixColumns];
    FillMatrixRandomNumbers(matrix1);
    FillMatrixRandomNumbers(matrix2);
    Console.WriteLine("Первая матрица:");
    WriteMatrix(matrix1);
    Console.WriteLine("Вторая матрица:");
    WriteMatrix(matrix2);
    int[,] resultMatrix = new int[firstMatrixColumns, firstMatrixColumns];
    for(int i = 0; i < matrix2.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (var k = 0; k < matrix1.GetLength(1); k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
    
        }
    }
Console.WriteLine("Результирующая матрица будет равна:");
WriteMatrix(resultMatrix);

}
    
else
Console.WriteLine("Вычислить произведение невозможно");


void FillMatrixRandomNumbers(int[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)  
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
       Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

