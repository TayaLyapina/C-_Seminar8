/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);


int temp = 0;
int minSum = 0;
int stringIndex=0;
for(int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            sum = sum + numbers[i,j]; 
        } 
       
        if(temp == 0) 
            temp = sum;
        if(temp>sum)
        {
            minSum = sum;
            stringIndex = i;
        }
        else
        {
            minSum = temp;
        }
    
        

    }
int rowMinSum = stringIndex +1;
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rowMinSum}");




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

