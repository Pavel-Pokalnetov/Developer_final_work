internal class Program
{
    private static void Main(string[] args)
    {
        string[][] myArray = new string[][]
        { //массив исходных данных
            new string[] { "hello", "2", "world", ":-)"},
            new string[] { "1234", "1567", "-2", "computer science" },
            new string[] { "Russia", "Denmark", "Kazan" }
        };

        // проверка решения

        Console.WriteLine(" вариант решения #1\n");
        foreach (string[] array in myArray)
        {
            PrintArray(array, " -> ");
            PrintArray(GetModArray(array), "\n\n");
        }

        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine(" вариант решения #2\n");
        foreach (string[] array in myArray)
        {
            PrintArray(array, " -> ");
            PrintArray(GetModArray(array), "\n\n");
        }

    }

    private static void PrintArray(string[] array, string optional = "")
    {   //печать массива в одну строку в виде ["X1", "X2", ... , "Xn"]
        // опционально можно вывести в конце дополнительную строку в аргументе string optional
        int arrayLen = array.Length - 1;
        if (arrayLen < 0)
        {
            Console.WriteLine($"[]{optional}");
            return;
        }
        Console.Write("[");
        for (int i = 0; i < arrayLen; i++)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        Console.Write($"\"{array[arrayLen]}\"]{optional}");
    }

    private static string[] GetModArray(string[] modArray)
    {   // метод решения задачи по варианту 1
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

    private static string[] GetModArray2(string[] modArray)
    {   // метод решения по варианту 2
        int count = 0;
        int arrayLen = modArray.Length;
        for (int i = 0; i < arrayLen; i++)
        {
            count += (modArray[i].Length < 4) ? 1 : 0;
        }
        string[] resultArray = new string[count];
        int index = 0;
        for (int i = 0; i < arrayLen; i++)
        {
            if (modArray[i].Length < 4) resultArray[index++] = modArray[i];
            if (index == count) break;
        }
        return resultArray;

    }

}

