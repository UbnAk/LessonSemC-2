// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int i = GetInt();
int second = PrintSecond(i);
System.Console.WriteLine(second);

int GetInt()
{
System.Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
return a;
}

int PrintSecond(int number)
{
    int a = number % 100;
    int b = number % 10;
    int c = (a - b) / 10;
    return c;
}
