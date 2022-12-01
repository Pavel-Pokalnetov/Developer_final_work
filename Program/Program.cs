internal class Program
{
    private static void Main(string[] args)
    {

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
}

