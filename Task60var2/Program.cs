/*Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int arrayMaxValue = 90;
int arrayMinValue = 10;
int arraySize = 2;
int[,,] array = new int[arraySize, arraySize, arraySize];

int[] additArray = new int [arraySize*arraySize*arraySize];

FillArrayRandomNumbers(additArray, arrayMinValue, arrayMaxValue);

int maxNumber = additArray[0];
for(int i = 0; i < additArray.Length; i++)
{
    if (additArray[i] > maxNumber)
    {
        maxNumber = additArray[i];
    } 
}

for(int i = 0; i < additArray.Length; i++)
{
    for(int j = i+1; j < additArray.Length; j++)
    {
        if(additArray[i] == additArray[j])
        {
            maxNumber++;
            additArray[j] = maxNumber;
        }
    }
}

int count = 0;
for(int j = 0; j < arraySize; j++)
{
    for(int k = 0; k < arraySize; k++)
    {
        for(int l = 0; l < arraySize; l++)
        {
            array[j, k, l] = additArray[count];
            count++;
            Console.Write($"{array[j, k, l]}({j}, {k}, {l}) " );
        }
        Console.WriteLine();

    }
}

void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

