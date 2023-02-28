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

int[] oldArray = { 6, 4, 8, 3, 9, 1, 2, 5, 7 };
Console.WriteLine("Изначальный массив:");
PrintArrayToConsole(oldArray);