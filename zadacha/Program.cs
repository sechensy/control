using System.Runtime.Serialization.Formatters;

namespace zadacha;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("сколько строк будет: ");
        int size = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[size];

        Console.WriteLine("Введите через enter строки");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
        }

        // string[] array = new string[3] { "afa", "3", "jadhfk" };
        int secondSize = 0;
        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]},");
        }
        //Console.WriteLine();

        Console.Write("\b");
        Console.Write(" ");
        Console.WriteLine();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3) secondSize++;
        }

        string[] secondArray = new string[secondSize];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                secondArray[j] = array[i];
                j++;
            }
        }
        Console.WriteLine("Получившийся массив, где длина каждой строки меньше или равна 3: ");
        for (int k = 0; k < secondSize; k++)
        {
            Console.Write($"{secondArray[k]},");
        }

        Console.Write("\b");
        Console.Write(" ");
        Console.WriteLine();

    }
}
