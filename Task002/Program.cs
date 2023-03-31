// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int number = GetInt();


int GetInt()
{
    System.Console.WriteLine("Введите число: ");
    return int.Parse(Console.ReadLine());

}

void Thirddigit()
{
if (number < 100)
{
    System.Console.WriteLine("Третьей циры нет!");
}
else if (number < 1000)
{
    System.Console.WriteLine(number % 10);
}
else if (number < 10000)
{
    int a = number % 100;
    int b = a / 10;
    System.Console.WriteLine(b);
}
else if (number < 100000)
{
    int a = number % 1000;
    int b = a / 100;
    System.Console.WriteLine(b);
}
}
Thirddigit();