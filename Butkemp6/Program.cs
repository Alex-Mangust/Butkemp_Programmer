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


Console.Clear();
System.Console.Write("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine()!);
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
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine(Check(array));
for(int k = 0; k < array.Length - 1; k++)
{
    for(int i = 0; i < array.Length - 1 - k; i++)
    {
        if(array[i] > array[i+1])
        {
            int temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
        }
    }
}
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine(Check(array));

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