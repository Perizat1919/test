/*Задание 2
Создайте консольное приложение, которое:
• Запрашивает у пользователя целое положительное число N.
• Выводит все четные числа от 1 до N.
• Подсчитывает количество выведенных четных чисел.
• Выводит полученное количество.*/
Console.WriteLine("Введите целое положительное число N: ");
int a = 0;
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Выводит все четные числа от 1 до N: ");
for (int i = 2; i <= N; i += 2)
{
    Console.Write(i + " ");
    a++;
}
Console.WriteLine();
Console.WriteLine("kolich" + a);

/*Задание 3
Создайте массив из 7 целых чисел. 

Напишите программу, которая: 

Заполните все элементы массива случайными числами, используя класс Random 

Находит максимальное число. 

Вычисляет сумму всех элементов. 

Подсчитывает количество элементов больше 10. 

Подсчитает количество повторений числа 8 

Вычислит среднее арифметическое положительных элементов */
int[] B = new int[7];
Random rnd= new Random();
for (int i = 0; i < B.Length; i++)
{
    B[i] = rnd.Next(1, 24);
}
Console.WriteLine("Массив: " + string.Join(" ", B));
int max = B[0];
int sum = 0;
int p = 0
;
int count = 0;
for (int i = 0; i < B.Length; i++)
{
    if (B[i] > max)
    {
        max = B[i];
        sum += B[i];
    }
    sum += B[i];
    if (B[i] > 10)
    {
        p++;
    }
    if (B[i] == 8)
    {
        count++;
    }
}
double avg = 0;
int pcount = 0;
for (int t = 0; t < B.Length; t++)
{
    if (B[t] > 0)
    {
        avg += B[t];
        pcount++;
    }
}
if (pcount > 0)
{
    avg /= pcount;
}
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Сумма всех элементов: " + sum);
Console.WriteLine("Количество элементов больше 10: " + p);
Console.WriteLine("Количество повторений числа 8: " + count);
Console.WriteLine("Среднее арифметическое положительных элементов: " + avg);

/*Задание 4
Разработайте программу для анализа введенного текста. 

Программа должна: 

Запросить у пользователя строку. 

Определить количество символов, включая пробелы. 

Подсчитать количество букв a и A без учета регистра. 

Вывести строку в верхнем регистре. */
Console.WriteLine("Введите строку: ");
string S = Console.ReadLine();
int len = S.Length;
int countA = 0;
for (int i = 0; i < len; i++)
{
    if (S[i] == 'a' || S[i] == 'A')
    {
        countA++;
    }
}
Console.WriteLine("Количество символов: " + len);
Console.WriteLine("Количество букв a и A: " + countA);
Console.WriteLine("Строка в верхнем регистре: " + S.ToUpper());

/*Задание 5*/
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Grade { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine("Имя: " + Name);
        Console.WriteLine("Возраст: " + Age);
        Console.WriteLine("Оценка: " + Grade);
    }

    public bool IsPassed()
    {
        return Grade >= 50;
    }
}

class lesson5
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "Alexey";
        student.Age = 18;
        student.Grade = 75;

        student.ShowInfo();

        if (student.IsPassed())
        {
            Console.WriteLine("Результат: Сдал");
        }
        else
        {
            Console.WriteLine("Результат: Не сдал");
        }
    }
}
