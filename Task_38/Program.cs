// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int Size = Prompt("Введите размерность массива");
int Min = Prompt("Введите минимальное значение элемента массива");
int Max = Prompt("Введите максимальное значение элемента массива");
double[] Array = GetArr(Size, Min, Max);
PrintArr(Array);
PrintResult(Array);

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}


double[] GetArr(int size, double min, double max)
{
    double[] ResultArray = new double[size];
    Random random = new Random();
    for (int i = 0; i < ResultArray.Length; i++)
    {
        ResultArray[i] = Math.Round((random.NextDouble() * (max - min) + min),2);

    }
    return ResultArray;
}

void PrintArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}

void PrintResult(double[] arr)
{
    Console.WriteLine($" => {(arr[arr.Length - 1])} - {arr[0]} = {Math.Round((arr[arr.Length - 1]) - arr[0], 2)}");
}
