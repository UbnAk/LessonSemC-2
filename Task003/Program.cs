//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int num = GetInt();

int GetInt()
{
    System.Console.WriteLine("Введите цифру: ");
    return int.Parse(System.Console.ReadLine());
}

void Whatday()
{
if (1 <= num && num <= 7)
{
    if(num == 6 || num == 7)
    {
        System.Console.WriteLine("Да, это выходной день!");
    }
    else
    {
        System.Console.WriteLine("Иди работай, до выходных еще далеко:)");
    }

}
else
{
    System.Console.WriteLine("Друг, в неделе всего 7 дней! Не больше и не меньше))");
}
}
Whatday();