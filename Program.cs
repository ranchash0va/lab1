
class task1
{
    //30
    //Дана последовательность натуральных чисел а1, а2, ..., an.
    //Создать массив из четных чисел этой последовательности.
    //Если таких чисел нет, то вывести сообщение об этом факте.

    public static void Run()
    {
        Console.WriteLine("task 30");


        // Ввод последовательности
        Console.WriteLine("Введите последовательность натуральных чисел через пробел:");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        int[] numbers = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            numbers[i] = int.Parse(parts[i]);
        }

        // Создание массива четных чисел
        int[] evenNumbers = new int[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenNumbers = evenNumbers.Concat(new int[] { numbers[i] }).ToArray();
            }
        }

        // Вывод массива четных чисел
        if (evenNumbers.Length > 0)
        {
            Console.WriteLine("Массив четных чисел:");
            foreach (int number in evenNumbers)
            {
                Console.Write(number + " ");
            }
        }
        else
        {
            Console.WriteLine("Последовательность не содержит четных чисел.");
        }

    }
}
class task2
{
    //116
    //На k-e место одномерного массива целых чисел вставить элемент,
    //равный разности двух введенных с клавиатуры элементов
    public static void Run()
    {
        Console.WriteLine("\n\ntask116");
        // Ввод массива
        Console.WriteLine("Введите массив целых чисел через пробел :");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        int[] numbers = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            numbers[i] = int.Parse(parts[i]);
        }

        // Ввод индекса для вставки
        Console.WriteLine("Введите индекс для вставки:");
        int k = int.Parse(Console.ReadLine());

        // Ввод элементов для разности
        Console.WriteLine("Введите первый элемент для разности:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второй элемент для разности:");
        int y = int.Parse(Console.ReadLine());

        // Вставка элемента
        int[] newNumbers = new int[numbers.Length + 1];
        for (int i = 0; i < k; i++)
        {
            newNumbers[i] = numbers[i];
        }
        newNumbers[k] = x - y;
        for (int i = k + 1; i < newNumbers.Length; i++)
        {
            newNumbers[i] = numbers[i - 1];
        }

        // Вывод массива
        Console.WriteLine("Массив после вставки:");
        foreach (int number in newNumbers)
        {
            Console.Write(number + " ");
        }
    }
}
class task3
{
    //123
    //Дана последовательность целых положительных чисел.
    //Найти произведение только тех из них, которые больше заданного числа М.
    //Если таких чисел нет, то выдать сообщение об этом.

    public static void Run()
    {
        Console.WriteLine("\n\ntask 123");

        Console.WriteLine("Введите последовательность целых положительных чисел (числа разделяются пробелами):");
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(' ');

        Console.Write("Введите число M: ");
        if (!int.TryParse(Console.ReadLine(), out int M))
        {
            Console.WriteLine("Некорректный ввод числа M.");
            return;
        }

        int product = 1;

        foreach (string numberString in numberStrings)
        {
            if (int.TryParse(numberString, out int number) && number > M)
            {
                product *= number;
            }
        }

       
if (product == 1)
        {
            Console.WriteLine($"В последовательности нет чисел больше {M}.");
        }
        else
        {
            Console.WriteLine($"Произведение чисел больше {M}: {product}");
        }
    }
}
class task4
{
    //142
    //Дана последовательность вещественных чисел а1, а2, ..., an.
    //Требуется умножить все члены последовательности а1, а2, ...,
    //an на квадрат ее наименьшего члена, если аk ≥ 0, и на квадрат ее наибольшего члена,
    //если аk < 0 (1 ≤ k ≤ n).

    public static void Run()
    {
        Console.WriteLine("\n\ntask 142");

        Console.WriteLine("Введите последовательность вещественных чисел через пробел:");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        double[] numbers = new double[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            numbers[i] = double.Parse(parts[i]);
        }

        double min = numbers[0];
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= 0)
            {
                numbers[i] *= min * min;
            }
            else
            {
                numbers[i] *= max * max;
            }
        }


        Console.WriteLine("Измененная последовательность:");
        foreach (double number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
class task5
{
    //179
    //Задан массив вещественных чисел и натуральные числа R и H < R.
    //Создать и заполнить массив номеров таких чисел исходного массива,
    //которые отличаются от R не более чем на Н.

    public static void Run()
    {
        Console.WriteLine("\n\ntask 179");
        // Ввод массива
        Console.WriteLine("Введите массив вещественных чисел через пробел:");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        double[] numbers = new double[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            numbers[i] = double.Parse(parts[i]);
        }

        // Ввод чисел R и H
        Console.WriteLine("Введите число R:");
        double R = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число H:");
        double H = double.Parse(Console.ReadLine());

        // Создание и заполнение массива номеров
        int[] numbersIndexes = new int[numbers.Length];
        int index = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (Math.Abs(numbers[i] - R) <= H)
            {
                numbersIndexes[index++] = i;
            }
        }

        // Вывод массива номеров
        Console.WriteLine("Массив номеров:");
        for (int i = 0; i < numbersIndexes.Length; i++)
        {
            Console.Write(numbersIndexes[i] + " ");
        }
    }
}
class Program
{
    static void Main()
    {

        task1.Run();
        task2.Run();
        task3.Run();
        task4.Run();
        task5.Run();
    }
}





