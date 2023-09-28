// Сортировка подсчетом

using System.Globalization;

Console.Clear();
int[] array = new int[] { 0, 2, 3, 2, 31, 5, 9, 1, 1, 0, 3, 4, 20 };
int max = int.MinValue;
for (int i = 0; i < array.Length; i++)
    if (max < array[i])
        max = array[i];
void CountingSort(int[] inputArray)
{
    int[] counters = new int[max + 1];
    // int ourNumber;
    for (int i = 0; i < inputArray.Length; i++) // массив повторений
    {
        counters[inputArray[i]]++;
        // ourNumber = inputArray[i];
        // counters[ourNumber]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i;
            index++;
        }
    }
}
System.Console.WriteLine(string.Join(", ", array));
CountingSort(array);
System.Console.WriteLine(string.Join(", ", array));