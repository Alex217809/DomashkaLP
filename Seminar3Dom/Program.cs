int input(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    
void Task23()
{
   //напищшите программу которая принимает на входе число N
   // и выдает таблицу кубов чисел от 1 до Т
   
   int N = input("Введите число ");

   Console.WriteLine ($"таблица кубов от 1 до {N} ");
      
      for (int i = 1; i <=N; i++)
    {
        {            
            Console.WriteLine ($"{i}^3 = {Math.Pow(i, 3)}");
        }
    }
    Console.WriteLine();
      
}



void Task21()
{
    //Напишите программу, которая принимает на вход 
    // координаты двух точек и находит расстояние между ними в 3D пространств

    double number(int x1, int x2, int y1, int y2, int z1, int z2)
  
    {
      return Math.Round((Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)+ Math.Pow(z2-z1, 2))), 2);
    }


      int x1 = input("Введите координаты X первой точки  ");
      int y1 = input("Введите координаты Y первой точки  ");
      int z1 = input("Введите координаты Z первой точки  ");

      int x2 = input("Введите координаты X второй точки  ");
      int y2 = input("Введите координаты Y второй точки  ");
      int z2 = input("Введите координаты Z второй точки  ");

      Console.WriteLine("Расстояние между точками ");
      Console.WriteLine(number(x1, y1, z1, x2, y2, z2));
     
}

void Task19()
{
      
    int number = input ("Введите пятизначное число  ");
    string numberStr = Convert.ToString(number);
    if (numberStr[0] == numberStr[4] && numberStr[1]== numberStr[3])
    {
      Console.WriteLine($"Число {number} является полиномом ");
    }

    else 
      Console.WriteLine($"Число {number} НЕ является полиномом ");
    
}



Console.Clear();
int task = input ("Введите номер задачи 19, 21 или 23  ");
switch (task)
{
   
    case 21:
      Task21();
      break;

    case 19:
      Task19();
      break;
    case 23:
      Task23();
      break;
  
     
   
      Console.WriteLine("Введен неправильный номер задачи");
      break;
}