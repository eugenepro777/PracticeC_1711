// Найти максимальную цифру 
// из рандомного трехзначного числа, используя метод 

int number = new Random().Next(100, 1000);

Console.WriteLine($"Случайное число: {number}");

int MaxDigit(int number)
{
int number1 = number / 100;
int number2 = number % 100 / 10;
int number3 = number % 10;
int max = 0;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

return max;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"максимальное число: {maxDigit}");