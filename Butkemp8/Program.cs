// Быстрая Сортировка O(n * log2(n))
// Напишите программу, которая сложит 2 числа a и b, без прямого сложения

// int sumNumbers(int x, int y)
// {
//     if(x == 0)
//         return y;
//     return sumNumbers(x - 1, y + 1);
// }

// Console.Clear();
// System.Console.Write("Введите 2 числа: ");
// int[] numbers = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// System.Console.WriteLine
// ($"Результат {numbers[0]} + {numbers[1]} = {sumNumbers(numbers[0], numbers[1])}");


// [7, 4, 1, 3, 5, 2, 6] -> [1, 2, 3, 4, 5, 6, 7]
// pivot(опора) = 7 (опорный элемент)
// [4, 1, 3, 5, 2, 6] + [7] + []
// pivot = 4
// [1, 3, 2] + 4 + [5, 6]
// pivot = 1
// [] + 1 + [3,2]
// pivot = 5
// [] + [5] + [6]
// pivot = 3
// [2] + [3] + []

void inputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 20);
    }
}

bool test(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i != array.Length - 1)
        {
            if(array[i] > array[i + 1])
                return false;
        }
    }
    return true;
}

int[] quickSort(int[] array, int leftIndex, int rightIndex)
{
    int i = leftIndex, j = rightIndex, pivot = array[leftIndex];
    while(i <= j)
    {
        while(array[i] < pivot)
        {
            i++;
        }
        while(array[j] > pivot)
        {
            j--;
        }
        if(i <= j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }
    if(leftIndex < j)
        quickSort(array, leftIndex, j);
    if(i < rightIndex)
        quickSort(array, i, rightIndex);
    return array;
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array);
System.Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
System.Console.WriteLine(test(array));
System.Console.WriteLine($"Конечный массив: [{string.Join(", ", quickSort(array, 0, array.Length - 1))}]");
System.Console.WriteLine(test(array));
