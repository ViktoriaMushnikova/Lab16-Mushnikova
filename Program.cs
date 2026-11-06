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

