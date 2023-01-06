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

/*Console.WriteLine("введи число");
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
}*/

//ДЗ №2
/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Обязательна проверка на ввод чисел больше/меньше 3-х знаков*/

Console.WriteLine("введи трехзначное число");
int num = int.Parse(Console.ReadLine()!);
if((num>=100) && (num<1000))
{
    Console.WriteLine($"{(num/10)%10} - вторая цифра числа {num}");
}
else
{
    Console.WriteLine($"{num} не является трехзначным числом");
}

/*Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000*/

Console.WriteLine("введи число от 0 до 100 000");
int number = int.Parse(Console.ReadLine()!);
if((number>=0) && (number<100))
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    if((number>=100) && (number<1000))
    {
        Console.WriteLine($"{number%10} - третья цифра числа {number}");
    }
    else
    {
        if((number>=1000) && (number<10000))
        {
            Console.WriteLine($"{(number/10)%10} - третья цифра числа {number}");
        }
        else
        {
            if((number>=10000) && (number<100000))
            {
                Console.WriteLine($"{(number/100)%10} - третья цифра числа {number}");
            }
            else
            {
                Console.WriteLine($"число {number} больше 100000");
            }
        }
    }
}

//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Обязательна проверка на ввод числа <1 и >7

Console.WriteLine("введи число от 1 до 7");
int n = int.Parse(Console.ReadLine()!);
if ((n==0) || (n>7))
{
    Console.WriteLine($"число {n} не соответствует условию ввода");
}
else
{
    if((n==6) || (n==7))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}