//напишите прогу, которая принимает на вход трехзначное число, а на выходе выдает вторую цифру этого числа
Console.WriteLine("Введите любое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num < 100) || (num > 1000)) 
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else 
{
    string str = num.ToString();
    Console.WriteLine($"{num} -> {str[1]}");
}
