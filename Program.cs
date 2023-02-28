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

int[] sortArrayBubble(int[] sortArray)
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
		Console.WriteLine($"<<< {current} итерация");
	}
	return sortArray;
}

int[] oldArray = { 6, 4, 8, 3, 9, 1, 2, 5, 7 };
Console.WriteLine("Изначальный массив:");
PrintArrayToConsole(oldArray);
Console.WriteLine();
int[] sortBubleArray = sortArrayBubble(oldArray);
Console.WriteLine("Отсортированный массив:");
PrintArrayToConsole(sortBubleArray);