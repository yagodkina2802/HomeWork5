// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] array = new double[5] { 3.22, 4.2, 1.15, 77.15, 65.2 };
  
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

double MaxEll(double[] arr)
{
    
    double maxx = arr[0];
    foreach (double ell in arr)
    {
        double temp = ell;
        if(temp > maxx) maxx = temp;
    }
    return maxx;

}
double MinEll(double[] arr)
{

    double min = arr[0];
    foreach (double ell in arr)
    {
        double temp = ell;
        if(temp < min) min = temp;
    }
    return min;

}




PrintArray(array);
Console.WriteLine();
double maxi = MaxEll(array);
double min = MinEll(array);
double inequality = maxi - min;

Console.WriteLine($"Разница между максимальным и минимальным значениями массива = {inequality}");
