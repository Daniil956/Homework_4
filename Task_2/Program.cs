// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int a = 452;
int sum = 0;
for (int i = 0; i < a; i++)
{
    sum = sum + a%10;
    a = a/10;
}
System.Console.WriteLine(sum);