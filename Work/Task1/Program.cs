// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16Console.Clear();


int DataEntry(int DigitA, int DigitB)
{
    int result = 1;
    for (int i = 1; i <= DigitB; i++)
    {
        result = result * DigitA;
    }
    return result;
}
Console.WriteLine("Введите число A: ");
int DigitA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int DigitB = int.Parse(Console.ReadLine());


int result = DataEntry(DigitA, DigitB);
Console.WriteLine(" Число " + DigitA + " в степени " + DigitB + " = " + result);



