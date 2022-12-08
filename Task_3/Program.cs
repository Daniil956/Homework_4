// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] arrey = new int[5];
int LEFTRABGE = 0;
int RAGTHRANGR = 10;

int[] FillArrey(int leftRange,  int rigthRange)
{
    Random rand = new Random();
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = rand.Next(LEFTRABGE, RAGTHRANGR);
    }
    return arrey;
}

arrey = FillArrey(LEFTRABGE, RAGTHRANGR);

Console.WriteLine(string.Join(", ", arrey) + " -> [" + string.Join(", ", arrey) + "]");