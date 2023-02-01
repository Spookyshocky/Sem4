// Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
void main()
{
    Console.Clear();
    Console.WriteLine("Введите число A: ");
    int cum = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите число B: ");
    int too = int.Parse(Console.ReadLine()!);

    int result = 1;
    int count = 1;
    while (count <= too)
    {
        result = result * cum;
        count++;
    }

    Console.WriteLine(result);
}

main();

