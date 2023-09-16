// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int WorkWithUser(string mes)
{
    Console.WriteLine(mes);
    int num = int. Parse(Console.ReadLine());
    return num;
}
int[] FillArray(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(99, 1000);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void FoundChetn(int[] arr)
{
int count = 0;
foreach (int ell in arr)
{
    if(ell % 2 == 0) count++;
}
Console.WriteLine(count);
}

int lenght = WorkWithUser("Введите длину: ");
int[] array = FillArray(lenght);
PrintArray(array);
Console.WriteLine();
FoundChetn(array);