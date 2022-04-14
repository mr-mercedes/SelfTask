Console.WriteLine("Задание 2: Даны 2 числа, показать большее и меньшее");
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (max > number2 )
{
    Console.WriteLine($"Число {max} больше чем чиcло {number2}");
}
else
{
    Console.WriteLine($"Число {number2} больше чем чиcло {max}");
}