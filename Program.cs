// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int number = userNumber;

while(number > 0)
{
    sum = sum + number % 10;
    number = number / 10;
}
Console.WriteLine($"Сумма всех цифр числа {userNumber} равна {sum}");