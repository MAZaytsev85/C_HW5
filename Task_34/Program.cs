// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Size = Prompt("Введите размерность массива");
int[] Array = GetArr(Size);
PrintArr(Array);
CountArrEvenNumber(Array);

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int[] GetArr(int size)
{
    int[] ResultArray = new int[size];
    for (int i = 0; i < ResultArray.Length; i++)
    {
        ResultArray[i] = new Random().Next(100, 1000);
    }
    return ResultArray;
}
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void CountArrEvenNumber(int[] arr)
{
    int EvenNumberCount = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0)
            EvenNumberCount++;
    }
    Console.WriteLine($"-> {EvenNumberCount}");
}
