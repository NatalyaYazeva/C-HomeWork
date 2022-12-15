//Зад.1: на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.WriteLine("введи 1 число");
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
}*/

//Зад.2: на вход три числа и выдаёт максимальное из этих чисел

/*Console.WriteLine("введи 1 число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введи 2 число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("введи 3 число");
int c = int.Parse(Console.ReadLine()!);
int max = a;

if(a>max) max = a;
if(b>max) max = b;
if(c>max) max = c;

Console.Write("max = ");
Console.WriteLine(max);*/

//Зад.3: на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.WriteLine("введи число");
int a = int.Parse(Console.ReadLine()!);
if (a%2==0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("Нечетное");
}*/

//Зад.4: на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("введи число");
int number = int.Parse(Console.ReadLine()!);
int number1=2;

while(number1<=number)
{
    if(number1%2==0)
    {
        Console.Write($"{number1} ");
        number1++;
    }
    else
    {
        number1++;
    }
}
