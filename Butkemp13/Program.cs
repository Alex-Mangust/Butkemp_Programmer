// Сортировка подсчетом

using System.Globalization;
int[] CountingSortExtended(int[] inputArray)
{
    // int max = int.MinValue;
    // for (int i = 0; i < inputArray.Length; i++)
    // if (max < inputArray[i])
    //     max = inputArray[i];
    int max = inputArray.Max();
    int min = inputArray.Min();
    int offset = -min;
    int[] sortedArray = new  int[inputArray.Length];
    int[] counters = new int[max + offset + 1];
    System.Console.WriteLine(max + offset + 1);
    for(int i = 0; i < inputArray.Length; i++)
        counters[inputArray[i] + offset]++;
    int index = 0;
    for(int i = 0; i < counters.Length; i++)
        for(int j = 0; j < counters[i]; j++)
        {
            sortedArray[index] = i - offset;
            index++;
        }
    return sortedArray;
}

Console.Clear();
int[] array = new int[] {-12, 32, -22, 10, 21, -4};
int[] sortedArray = CountingSortExtended(array);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(string.Join(", ", sortedArray));
