//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

const int MIN_ELEMENTS = 1;
const int MAX_ELEMENTS = 100;

int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1);
    }
    return answer;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}

int OddNumberSumm(int[] arr)
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        summ += arr[i];
    }
    return summ;
}

Random rnd = new Random();
int[] array = GenerateArray(rnd.Next(5, 20), MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(array);
System.Console.WriteLine($"Сумма нечетных элементов массива равна {OddNumberSumm(array)}");