internal class Program
{
    private static void Main(string[] args)
    {
        string[][] myArray = new string[][]
        {
            new string[] { "hello", "2", "world", ":-)"},
            new string[] { "1234", "1567", "-2", "computer science" },
            new string[] { "Russia", "Denmark", "Kazan" }
            };
    }

    private static void PrintArray(string[] array)
    {
        int arrayLen = array.Length - 1;
        if (arrayLen < 0)
        {
            Console.WriteLine("[]");
            return;
        }
        Console.Write("[");
        for (int i = 0; i < arrayLen; i++)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        Console.Write($"\"{array[arrayLen]}\"]");
    }

    private static string[] GetModArray(string[] modArray)
    {
        int arrayLen = modArray.Length;
        int count = 0;
        string[] tempArray = new string[arrayLen];
        for (int i = 0; i < arrayLen; i++)
        {
            if (modArray[i].Length < 4)
            {
                tempArray[count++] = modArray[i];
            }
        }
        string[] resultArray = new string[count];
        Array.Copy(tempArray, resultArray, count);
        return resultArray;
    }
}

