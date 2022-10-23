// Напишите программу которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int stepen = 3;

for(int i = 1; i < n + 1; i++)
{  
   Console.WriteLine(Math.Pow(i, stepen)); 
}
