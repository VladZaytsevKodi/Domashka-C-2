// Напишите программу, которая принимает на вход пятизнаное значение
// и проверяет является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int palindrome = int.Parse(Console.ReadLine()!);

int num5 = palindrome % 10;
int num1 = palindrome / 10000;

int num4 = palindrome % 100 / 10;
int num3 = palindrome / 1000 % 10;

if(num5 == num1 && num4 == num3) Console.WriteLine($"число {palindrome} является палиндромом");
else Console.WriteLine($"число {palindrome} неявляется палиндромом");

