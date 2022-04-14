Console.WriteLine("Задание №3: По заданному номеру дня недели вывести его название");
Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("Указанный номер дня недели это Понедельник");
} 
if (day == 2)
{
    Console.WriteLine("Указанный номер дня недели это Вторник");
} 
if (day == 3)
{
    Console.WriteLine("Указанный номер дня недели это Среда");
}
if (day == 4)
{
   Console.WriteLine("Указанный номер дня недели это Четверг"); 
}
if (day == 5)
{
    Console.WriteLine("Указанный номер дня недели это Пятница"); 
}
if (day == 6)
{
    Console.WriteLine("Указанный номер дня недели это Суббота"); 
}
if (day == 7)
{
    Console.WriteLine("Указанный номер дня недели это Воскресенье");
}
if (day > 7 || day < 1)
{
    Console.WriteLine("В неделе только 7 дней, выберите число от 1 до 7");
}