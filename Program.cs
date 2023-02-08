//-----------------Домашнее задание №1-------------------------------

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

//-----------------Домашнее задание №2-------------------------------

/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Обязательна проверка на ввод чисел больше/меньше 3-х знаков*/

/*Console.WriteLine("введи трехзначное число");
int num = int.Parse(Console.ReadLine()!);
if((num>=100) && (num<1000))
{
    Console.WriteLine($"{(num/10)%10} - вторая цифра числа {num}");
}
else
{
    Console.WriteLine($"{num} не является трехзначным числом");
}*/

/*Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000*/

/*Console.WriteLine("введи число от 0 до 100 000");
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
}*/

//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Обязательна проверка на ввод числа <1 и >7

/*Console.WriteLine("введи число от 1 до 7");
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
}*/

//-----------------Домашнее задание №3-------------------------------

//Задача 1: принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*Console.Write("введи 5-тизначное число: ");
int n = int.Parse(Console.ReadLine()!);
string N = n.ToString();
if (N.Length == 5)
{
    if (N[0]==N[4] && N[1]==N[3])
    {
        Console.WriteLine($"число {n} является палиндромом");
    }
    else
    {
        Console.WriteLine($"число {n} не является палиндромом");
    }
}
else
{
    Console.WriteLine($"введено не верное число");
}*/

//принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

/*Console.Write("введи X1: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("введи Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("введи Z1: ");
int Z1 = int.Parse(Console.ReadLine()!);
Console.Write("введи X2: ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("введи Y2: ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.Write("введи Z2: ");
int Z2 = int.Parse(Console.ReadLine()!);

double res =Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));
Console.WriteLine($"расстояние между точками: {res:f2}");*/

//принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*Console.Write("введи число: ");
int n = int.Parse(Console.ReadLine()!);
for(int i = 1; i <=n; i++){
    Console.Write($"{Math.Pow(i, 3)} ");
}*/

//-----------------Домашнее задание №4-------------------------------


// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*Console.Write("Введи число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введи число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} равно {GetPower(A, B)}");*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*Console.Write("Введи число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {num} равно {SumNums(num)}");*/

//Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

/*int[] Array = GetArray(8);
Console.WriteLine($"[{String.Join(",", Array)}]");*/

//---------------Методы---------------
//Задача 1
/*int GetPower(int A, int B){
    int power = 1;
    for(int i = 1; i<=B; i++){
        power = power * A;
    }
    return power;
}*/
//задача 2
/*int SumNums (int num){
    int sum = 0;
    while (num > 0){
        sum = sum + num%10;
        num = num / 10;
    }
    return sum;
}*/
//залача 3

/*int[] GetArray(int size){
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++){
        myArray[i] = new Random().Next();
    }
    return myArray;
}*/

//-----------------Домашнее задание №5-------------------------------

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.*/

/* int[] array = GetArray(10, 1, 1000);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Количество четных чисел равно {CountElements(array)}");*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

/*Console.WriteLine("Задача 36");
int[] array = GetArray(10, 1, 101);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Сумма элементов нечетных индексов {SumElIndex(array)}");*/

//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.

/*Console.WriteLine("Задача 37");
int[] array = GetArray(10, 1, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
if (array.Length % 2 ==0)
{
    int [] myArray = GetNewArray1 (array);
    Console.WriteLine($"[{String.Join(",", myArray)}]");
}
else
{
    int [] myArray = GetNewArray2 (array);
    Console.WriteLine($"[{String.Join(",", myArray)}]");
}*/



//---------------Методы---------------
/*int[] GetArray (int size, int minValue, int maxValue){
    int[] res = new int [size];
    for(int i=0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int CountElements(int[] array)
{   int count = 0;
    foreach (int el in array)
    {
        if(el%2 == 0){
        count++;
        }
    } return count;
}

int SumElIndex(int[] array)
{   int index = 0;
    int sum = 0;
    foreach (int el in array)
    {
        if(index%2 > 0){
        sum +=el;
        }
        index++;
    } return sum;
}


int[] GetNewArray1 (int[] array){
    int index = 0;
    int N = array.Length;
    int[] myArray = new int[N/2];
    for(int i = 0; i <= N/2-1; i++)
    {
        myArray[index] = array[index]*array [N-index-1];
        index++;
    } 
    return myArray;
}

int[] GetNewArray2 (int[] array){
    int index = 0;
    int N = array.Length;
    int[] myArray = new int[N/2+1];
    for(int i = 0; i <= N/2; i++)
    {
        if (i < N/2)
        {
            myArray[index] = array[index]*array [N-index-1];
            index++;
        }
        if (i == N/2)
        {
            myArray[index] = array[index];
        }
    } 
    return myArray;
}*/

//---------------------------Домашнее задание №6--------------------------------------


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
/*Console.Write($"Введите через пробел несколько чисел: ");
String Array = Console.ReadLine()!;
string[] numS = Array.Split(' ', StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"Из {CountNums(numS)} чисел - {CountNums2(numS)} положительных");

//--------Методы---------------

int CountNums(string[] num){
    int count = num.Length;
    return count;
}

int CountNums2(string[] num)
{   int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (int.Parse(num [i]) > 0){
        count++;
        }
    } return count;
}*/


// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100,
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).
/*Console.Write("Введи количество элементов массива (не менее 6): ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size, 0, 101);
Console.WriteLine($"[{String.Join(",", array)}]");
SelectionSort(array);
Console.WriteLine($"[{String.Join(",", array)}]");*/

//--------Методы---------------

/*int[] GetArray (int size, int minValue, int maxValue){
    int[] res = new int [size];
    for(int i=0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}


void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array [minPosition])  minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}*/

//-----------------------------Домашнее задание №7--------------------------------------------

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*Console.WriteLine("Введи количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

//----------------Методы--------------
double[,] GetArray(int m, int n, int minValue, int maxValue){
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i,j] = Math.Round(new Random().NextDouble(),2);
        }
    }
    return result;
}

void PrintArray(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1);j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}*/

//Задача 50. Напишите программу, которая на вход принимает число, проверяя есть ли такое число в двумерном массиве
// и возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.

/*Console.WriteLine("Введи количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);

if(FindElement(array, A))
{
    Console.WriteLine("данный элемент в массиве есть");
}
else{
    Console.WriteLine("данного элемента в массиве нет");
}

//----------------Методы--------------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1);j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

bool FindElement (int[,] array, int A){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if(array[i,j]==A){
                return true;
            }
        }
    } return false;
}*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введи количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[] myArray = SelectArray (array);

double[] myArray2 = new double [myArray.Length];
for (int i =0; i < myArray.Length; i++){
    myArray2 [i] = Math.Round (myArray [i], 2);
}

Console.WriteLine($"[{String.Join("; ", myArray2)}]");

//----------------Методы--------------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1);j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

double [] SelectArray(int[,] array){
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    double[] myArray = new double [m];
    for (int j = 0; j < m; j++)
    {
        int i = 0;
        double sum = 0;
        while (i < n){
        sum += array[i,j];
        myArray[j] = sum/n;
        i++;
        }
    }
    return myArray;
}