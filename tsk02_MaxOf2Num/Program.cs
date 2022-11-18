Console.Write("Введите первое число: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b=Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.Write("Большее из введенных чисел - ");
    Console.WriteLine(a);
    Console.Write("Меньшее из введенных чисел - ");
    Console.WriteLine(b);
}
else
{
    Console.Write("Большее из введенных чисел - ");
    Console.WriteLine(b);
    Console.Write("Меньшее из введенных чисел - ");
    Console.WriteLine(a);
}