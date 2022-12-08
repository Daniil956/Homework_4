// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int enterAB(string str)
{
    Console.Write(str); 
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int A = enterAB("Write  a number that will be raiseb to a power:  ");
int B = enterAB("Number power: ");
int result = 1;
for(int i = 1; i <= B; i++)
{
    result = A * result;
}

Console.WriteLine($"Result = " + result);


