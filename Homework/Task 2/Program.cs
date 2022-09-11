//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

const double MIN_ELEMENTS = 1.0;
const double MAX_ELEMENTS = 100.0;

double[] GenerateArray(int length, double minRandom, double maxRandom)
{
    Random rnd = new Random();
    double[] answer = new double[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = Math.Round(rnd.NextDouble() * (maxRandom - minRandom) + minRandom, 2);
    }
    return answer;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}

double MaxMinDifference (double[] arr)
{
    double minValue = arr[0];
    double maxValue = arr[0];
    double difference = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minValue)
        {
            minValue = arr[i];
        }
        if (arr[i] > maxValue)
        {
            maxValue = arr[i];
        }
    }
    return difference = maxValue - minValue;
}

Random rnd = new Random();
double[] array = GenerateArray(rnd.Next(5, 10), MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {MaxMinDifference(array)}");
