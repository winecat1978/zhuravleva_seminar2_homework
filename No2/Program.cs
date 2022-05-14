// напишите прогу, которая выводит 3 цифру заданного числа или сообщает, что его нет
Console.WriteLine("Введите любое натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num < 100) && (num > -100))
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
else 
{
    string str = num.ToString();
    Console.WriteLine($"{num} -> {str[2]}");
}