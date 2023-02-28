void PrintArrayToConsole(int[] printArray)
{
    Console.Write("[");
    for (int i = 0; i < printArray.Length; i++)
    {
    	if (i == printArray.Length - 1)
        	Console.Write($"{printArray[i]}");
        else
        	Console.Write($"{printArray[i]}, ");
    }
    Console.Write("]");
}

int[] SortArrayBubble(int[] sortArray)
{
	int size = sortArray.Length;

	for (int current = 0; current < size - 1; current++)
	{
		for (int i = 0; i < size - 1; i++)
		{
			if (sortArray[i] > sortArray[i + 1])
			{
				int temp = sortArray[i];
				sortArray[i] = sortArray[i + 1];
				sortArray[i + 1] = temp;
			}
		}
		PrintArrayToConsole(sortArray);
		Console.WriteLine($"<<< {current + 1} итерация");
	}
	return sortArray;
}

int GetRandomNumber(int min, int max)
{
	Random rnd = new Random();
	return rnd.Next(min, max + 1);
}

int[] GetRandomArray(int length)
{
	int[] randomArray = new int[length];
	for (int i = 0; i < length; i++)
	{
		randomArray[i] = GetRandomNumber(0, 100);
	}
	return randomArray;
}

int size = GetRandomNumber(1, 50);
int[] oldArray = GetRandomArray(size);
Console.WriteLine("Изначальный массив:");
PrintArrayToConsole(oldArray);
Console.WriteLine();
int[] sortBubleArray = SortArrayBubble(oldArray);
Console.WriteLine("Отсортированный массив:");
PrintArrayToConsole(sortBubleArray);