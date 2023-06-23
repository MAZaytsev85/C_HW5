// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int Size = Prompt("Введите размерность массива");
int Min = Prompt("Введите минимальное значение элемента массива");
int Max = Prompt("Введите максимальное значение элемента массива");
int[] Array = GetArr(Size, Min, Max);
PrintArr(Array);
CountArrNotEvenNumber(Array);

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int[] GetArr(int size, int min, int max)
{
    int[] ResultArray = new int[size];
    for (int i = 0; i < ResultArray.Length; i++)
    {
        ResultArray[i] = new Random().Next(min, max);
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

void CountArrNotEvenNumber(int[] arr)
{
    int NotEvenNumberCount = 0;
    for (int i = 1; i < arr.Length; i+=2) 
    {
        NotEvenNumberCount += arr[i];
    }
    Console.WriteLine($"-> {NotEvenNumberCount}");
}
