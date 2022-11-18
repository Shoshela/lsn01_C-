Console.WriteLine("Введите числа...");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int c=Convert.ToInt32(Console.ReadLine());

if ((b < a) && (a > c))
    {
        Console.Write("Максимальное из введенных чисел - ");
        Console.WriteLine(a);
    }

    else if ((a < b) && (b > c))
    {
        Console.Write("Максимальное из введенных чисел - ");
        Console.WriteLine(b);
    }

    else
    {
        Console.Write("Максимальное из введенных чисел - ");
        Console.WriteLine(c);
    }