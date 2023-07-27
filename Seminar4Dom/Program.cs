
      int input(string text)
      {
         Console.WriteLine(text);
         return Convert.ToInt32(Console.ReadLine());
      }
    
   
void Task25()
{
// Используя определение степени числа, напишите цикл, который 
// принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
   int A = input ("Введите число A ");
   int B = input ("Введите число B ");
   
   Console.WriteLine($"{A}^{B} = {Math.Pow(A, B)}"); 
}

void Task27()
   {
    // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    // 452 -> 11
    // 82 -> 10
    // 9012 -> 12
   
   int number = input ("введите число ");
   Console.Write($"сумма цифр числа {number} = ");
      int sum = 0;
   for (int i = number; i > 0; i/=10)
    {
    sum = sum + i % 10;
    }
   Console.WriteLine($"{sum}");

}

void Task29() 
{
// Напишите программу, которая задаёт массив из 8 случайных целых чисел 
// и выводит отсортированный по модулю массив.
// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
// 6, 1, -33 -> [1, 6, -33]
int size = 8;
Random rnd = new Random();

int[] numbers = new int[size];
   
   for (int i = 0; i<size; i++)
   {
      numbers[i] = rnd.Next(-100, 100);      
   }

   for (int i = 0; i<size; i++)
   {
        if (numbers[i] < 0)
        {
            numbers[i] = Math.Abs(numbers[i]);
        }
   }

    Array.Sort(numbers);
  
    Console.WriteLine("Массив отсортированный по возрастанию: ");
            for (int i = 0; i < size; i++) 
            {
                Console.Write($"{numbers[i]}  ");
                
            }
Console.WriteLine();
}

Console.Clear();
int task = input ("Введите номер задачи ");
switch (task)
{
case 25:
      Task25();
      break;

case 27:
      Task27();
      break;
   
case 29:
      Task29();
      break;

Console.WriteLine("Введен неправильный номер задачи");
      break;
}