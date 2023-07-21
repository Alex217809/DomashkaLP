void Task23()
{
   //напищшите программу которая принимает на входе число N
   // и выдает таблицу кубов чисел от 1 до Т
   int input(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
   
   int N = input("Введите число ");

   Console.WriteLine ($"таблица кубов от 1 до {N} ");
      
      for (int i = 1; i <=N; i++)
    {
        {            
            Console.WriteLine ($"{Math.Pow(i, 3)}");
        }
    }
    Console.WriteLine();
      
}

Console.Clear();
Task23();
