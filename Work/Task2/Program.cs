// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();

int DataEntry(int number)
{
    int sum = 0;
    int digit = 0;
    while (number > 0)
    {
        digit = number % 10;
        sum = sum + digit;
        number = number / 10;

    }
    return sum;
}
Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());

int sum = DataEntry(number);
Console.WriteLine(number + " -> " + sum);

