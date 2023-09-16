// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int WorkWithUser(string mes)
{
    Console.WriteLine(mes);
    int num = int. Parse(Console.ReadLine());
    return num;
}
int[] FillArray(int lenght, int min, int max)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
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

void Sum(int[] arr)
{
    int summa = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        summa += arr[i];
        i++;
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {summa}");
}

int lenght = WorkWithUser("Введите длину: ");
int minV = WorkWithUser("Введите минимальное значение массива: ");
int maxV = WorkWithUser("Введите максимальное значение массива:");
int[] array = FillArray(lenght, minV, maxV);
PrintArray(array);
Console.WriteLine();
Sum(array);