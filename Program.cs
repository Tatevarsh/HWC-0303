// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int count = 1;
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine()!);

while (count <= a)
{
    Console.WriteLine(count * count * count);
if (count !=a)
{

}
    count++;
}


