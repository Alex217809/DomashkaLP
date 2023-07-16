void Task9()
{
    int number = (456);
    int f_digit = number / 100;
    int s_digit = number % 100;
    int t_digit = number % 10;

    Console.WriteLine($"Выводим второе число {s_digit/10}");
}

Task9();