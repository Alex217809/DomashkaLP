void Task10()
{
    // Напишите программу, которая принимает на вход 
    // трёхзначное число и на выходе показывает вторую цифру этого числа
    int input (string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    
    int num = input("Введите трехзначное число   ");
    
     Console.WriteLine($"Выводим вторую цифру {(num /10 % 10)}");
}


void Task13()

{
    //  Напишите программу, 
    // которая с помощью деления выводит третью цифру заданного числа 
    // или сообщает, что третьей цифры нет.
    int input (string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    int num = input("Введите число");
    
   if (num > 99)
    {
        Console.Write($" В данном числе {num}");
        while (num >999)
        {
            num/=10;
        }
        Console.WriteLine($" третья цифра {(num % 10)}");
    }
    else 
    {
        Console.WriteLine($" третья цифры нет");
    }
}

void Task15()

{
    //  Напишите программу, 
    // которая принимает на вход цифру, обозначающую день недели,
    // и проверяет, является ли этот день выходным
    int input (string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    int day = input("Введите число от 1 до 7 соотвестующее дню недели ");
    
   if (day == 6 || day == 7)
    {
        Console.WriteLine($"Данный {day}-й день недели является выходным");
    }
    else 
    {
        Console.Write($" Данный {day}-й день недели НЕ является выходным");
    }
}


void Task16()
{
    // напишите программу которая выводит случайное число из
    // отрезка 10 1000 и и сделайте из него двухзначное убрав посередине цифру
   
    int number = new Random().Next(99, 1000); 

    Console.WriteLine($"выпало случайное число {number}");

    int f_digit = number / 100;
    int s_digit = number % 100;
    // проверить
    int t_digit = number % 10;

    Console.WriteLine($"первая цифра {f_digit}");

    Console.WriteLine($"вторая цифра {s_digit}");

     Console.WriteLine($"третья цифра {t_digit}");


    Console.WriteLine($"двухзначное число {f_digit}{t_digit}");
}


void Task17_Dop()
{
        int input (string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    } 

    int f_side = input ("Введите длину первой стороны ");
    int s_side = input ("Введите длину второй стороны ");
    int t_side = input ("Введите длину третьей стороны ");

    if (f_side == s_side  || f_side == t_side || s_side == t_side)
    {
        Console.WriteLine($"Треугольник является равнобедренным ");
    }
    else
        Console.WriteLine($"Треугольник НЕ является равнобедренным ");
    
}
// Написать программу, которая определяет, является ли 
// треугольник со сторонами a, b, c равнобедренным.

Console.Clear();
Task17_Dop();