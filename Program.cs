using System.Globalization;
using System.Linq.Expressions;
using Microsoft.Win32.SafeHandles;

Console.WriteLine("Шаг 1. Создание и заполнение массива");
Console.WriteLine("Сколько студентов в группе? ");
int studentsCount = int.Parse(Console.ReadLine()!);
int[] grades = new int[studentsCount];
int sum = 0;
for (int i = 0; i < grades.Length; i++) {
    Console.Write($"Оценка студента {i + 1}: ");
    grades[i] = int.Parse(Console.ReadLine()!);
}

foreach (int grade in grades) {
    Console.WriteLine(grade);
    sum += grade;
}
Console.WriteLine($"Средний балл группы: {(double)sum / grades.Length}");


Console.WriteLine("Шаг 2. Изменение элементов массива");
int[] points = { 4, 7, 2, 9, 5, 10 };

for (int i = 0; i < points.Length; i++)
{
    if (points[i] < 10)
    {
        points[i] = points[i] + 1;
    }
}

foreach (int point in points)
{
    Console.WriteLine(point);
}


Console.WriteLine("Шаг 3. Сортировка массива");
int[] grades1 = { 4, 5, 3, 5, 4, 2 };

for (int i = 0; i < grades1.Length - 1; i++)
{
    for (int j = 0; j < grades1.Length - 1 - i; j++)
    {
        if (grades1[j] < grades1[j + 1])
        {
            int temp = grades1[j];
            grades1[j] = grades1[j + 1];
            grades1[j + 1] = temp;
        }
    }
}

foreach (int grade1 in grades1)
{
    Console.WriteLine(grade1);
}

Console.WriteLine("Шаг 4. Метод, возвращающий массив");
int[] GenerateScheduleSlots(int lessonsCount)
{
    int[] slots = new int[lessonsCount];

    for (int i = 0; i < lessonsCount; i++)
    {
        slots[i] = i + 1;
    }
    return slots;
}

int[] GenerateEvenSlots(int lessonsCount)
{
    int[] slots1 = new int[lessonsCount];
    for (int i = 0; i < lessonsCount; i++)
    {
        slots1[i] = (i + 1) * 2;
    }
    return slots1;
}

int[] slots = GenerateScheduleSlots(6);
int[] evenSlots = GenerateEvenSlots(6);
foreach (int slot in slots)
{
    Console.WriteLine(slot);
}
foreach (int slot1 in evenSlots)
{
    Console.WriteLine($"Чётные номера: {slot1}");
}


Console.WriteLine("Шаг 5. Знакомство с Array.Sort()");
int[] grades2 = { 4, 5, 3, 5, 4, 2 };
Array.Sort(grades2);

foreach (int grade2 in grades2)
{
    Console.WriteLine(grade2);
}


Console.WriteLine("Задача А");
Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine()!);
int[] N = new int[numberN];

for (int i = 0; i < numberN; i++)
{
    N[i] = (i + 1) * (i + 1);
}
Console.WriteLine("Квадрат числа: ");
foreach (int N1 in N)
{
    Console.WriteLine(N1);
}


Console.WriteLine("Задача Б");
int[] numbers = { 3, -3, 5, -5, 9 };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
    {
        numbers[i] = 0;
    }
}
foreach (int number in numbers)
{
    Console.WriteLine(number);
}


Console.WriteLine("Вариант 4");
int[] GenerateFibonacci(int n)
{
    int[] fibonacci = new int[n];
    fibonacci[0] = 1;
    fibonacci[1] = 1;
    for (int i = 2; i < n; i++)
    {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
    return fibonacci;
}
int[] numberFibonacci = GenerateFibonacci(5);
foreach (int i in numberFibonacci)
{
    Console.WriteLine(i);
}


Console.WriteLine("Вариант 5");
int[] num = { 3, 4, 6, 8, 1 };

for (int i = 0; i < num.Length / 2; i++)
{
    int numberNum = num.Length - 1 - i;
    int number0 = num[i];
    num[i] = num[numberNum];
    num[numberNum] = number0;
}
foreach(int i in num)
{
    Console.WriteLine(i);
}