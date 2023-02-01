// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = Console.ReadLine()
                .Split(' ', ',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
Console.WriteLine(string.Join(", ", arr));
