// написать прогу, которая на число от 1 до 7, а выдает является ли этот день выходным
Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num > 0) && (num < 6))
{
    Console.WriteLine("нет");
}
if (num == 6) Console.WriteLine("да");
if (num == 7) Console.WriteLine("да");
 