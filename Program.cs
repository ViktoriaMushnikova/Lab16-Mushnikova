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