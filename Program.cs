//на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("введи 1 число");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("введи 2 число");
int numB = int.Parse(Console.ReadLine()!);
if (numA>numB)
{
    Console.WriteLine($"большее число {numA}, меньшее число {numB}");
}
else
{
    Console.WriteLine($"большее число {numB}, меньшее число {numA}");
}
