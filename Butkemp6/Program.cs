// Пузырьковая сортировка
// O O O O O O O
// N1 1         O(0)

// N2 2 1       O(1)

// N3 3 2 1     O(2)
//    2 1 3
//    1 2 3

// N4 4 3 2 1   O(4)
//    3 2 1 4
//    2 1 3 4
//    1 2 3 4


// Nn = (n-1) для одного элемента, чтобы он встал на свою позицию
// (n-1)^2   n^2 - 2n + 1  для n элементов, чтобы каждый встал на свою позицию


// System.Console.Write("Введите кол-во элементов: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 10);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// for (int i = 0; i < array.Length; i++)
// {
//    for(int j = i; j < array.Length; j++)
//    {
//         if (array[i] > array[j])
//         {
//             int temp = array[j];
//             array[j] = array[i];
//             array[i] = temp;
//         }
//    }
// }
// System.Console.WriteLine($"[{string.Join(", ", array)}]");

using System.Diagnostics;
Console.Clear();
bool show = true;
System.Console.Write("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine()!);
bool inputShow = false;
while(!inputShow)
{
    System.Console.WriteLine("Вывести массисы в консоль? \n 1 - да \t 2 - нет");
    int shows = int.Parse(Console.ReadLine()!);
    if(shows == 1)
    {
        show = true;
        inputShow = true;
    }
    else if(shows == 2)
    {
        show = false;
        inputShow = true;
    }
    else System.Console.WriteLine("Пожалуйста, введите либо 1, либо 2");
}
int[] array = new int[n];

bool Check(int[] array)  // Пример юнит-теста (Проверяет, отсортирован ли массив)
{
    int size = array.Length - 1;
    for(int i = 0; i < size; i++)
    {
        if(array[i] > array[i+1]) return false;
    }
    return true;
}

for(int i = 0; i < array.Length; i++)
    array[i] = Random.Shared.Next(100);
int[] arr1 = new int[n];
int[] arr2 = new int[n];
Array.Copy(array, arr1, n);
Array.Copy(array, arr2, n);
if(show) System.Console.WriteLine($"[{string.Join(", ", arr1)}]");
Stopwatch sw = new Stopwatch();
sw.Start();
for(int k = 0; k < arr1.Length - 1; k++)
{
    for(int i = 0; i < arr1.Length - 1 - k; i++)
    {
        if(arr1[i] > arr1[i+1])
        {
            int temp = arr1[i];
            arr1[i] = arr1[i + 1];
            arr1[i + 1] = temp;
        }
    }
}
sw.Stop();
System.Console.WriteLine($"arr1 - {Check(arr1)} {sw.ElapsedMilliseconds}ms");
if(show) System.Console.WriteLine($"arr1: [{string.Join(", ", arr1)}]");
Console.ReadLine();
if(show) System.Console.WriteLine($"[{string.Join(", ", arr2)}]");
sw.Reset();
sw.Start();
for(int k = 0; k < arr2.Length - 1; k++)
{
    for(int i = 0; i < arr2.Length - 1; i++)
    {
        if(arr2[i] > arr2[i+1])
        {
            int temp = arr2[i];
            arr2[i] = arr2[i + 1];
            arr2[i + 1] = temp;
        }
    }
}
sw.Stop();
System.Console.WriteLine($"arr2 - {Check(arr2)} {sw.ElapsedMilliseconds}ms");
if(show) System.Console.WriteLine($"arr2: [{string.Join(", ", arr2)}]");

// int j = 0;
// for(j = 0; j < n; j++)
// {
//     if(j == 0) System.Console.Write("[");
//     System.Console.Write(array[j]);
//     if( j != n - 1) System.Console.Write(", ");
//     else System.Console.Write("]");
// }
// System.Console.WriteLine();
// j = 0;
// while(j < n) 
// {
//     if(j == 0) System.Console.Write("[");
//     System.Console.Write(array[j++]);
//     if(j != n) System.Console.Write(", ");
//     else System.Console.Write("]");
// }