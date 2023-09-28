// Сортировка подсчетом

int[] array = new int[] {0,2,3,2,1,5,9,1,1};

void CountingSort(int[] inputArray)
{
    int[]counters = new int[10];
    // int ourNumber;
    for(int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++;
        // ourNumber = inputArray[i];
        // counters[ourNumber]++;
    }

    for(int i = 0; i < inputArray.Length; i++)
    {

    }
}
