// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputeIntNumber(string message)
{
    int number = 0;
    Console.Write(message);
    number = Convert.ToInt32(Console.ReadLine());

    while (number < 1)
    {
        System.Console.WriteLine("Некорректный ввод!");
        Console.Write(message);
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

int SumNatural(int num1, int num2)
{
    int result = num1;
    if (num1 == num2)
        return 1;
    if (num1 > num2)
    {
        num2++;
        result = num2 + SumNatural(num2, num1);
        return result;
    }
    else
    {
        num1++;
        result = num1 + SumNatural(num1, num2);
        return result;
    }
}

Console.WriteLine("Введите два натуральных положительных числа");
int number1 = InputeIntNumber("Введите 1-е натуральное положительное число: ");
int number2 = InputeIntNumber("Введите 2-е натуральное положительное число: ");

int sumNumbers = SumNatural(number1, number2);
Console.WriteLine($"Сумма натуральных положительных чисел от {number1} до {number2} = {sumNumbers}");