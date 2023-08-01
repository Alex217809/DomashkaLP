int input(string text)
      {
         Console.WriteLine(text);
         return Convert.ToInt32(Console.ReadLine());
      }
 
   
void Task34()
{
//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая 
//покажет количество чётных чисел в массиве

void FillArray(int[] array, int minValue = 100, int maxValue = 999)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array [i]}");
    }
}

int size = input ("введите размер массива  ");
int [] numbers = new int[size];

FillArray(numbers);
PrintArray(numbers);

    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }   

   Console.WriteLine($"Количество четных чисел {count}"); 
}

void Task36()
{
//Задайте одномерный массив, 
// заполненный случайными числами. Найдите 
// сумму элементов с нечётными индексами.

void FillArray(int[] array, int minValue = 100, int maxValue = 999)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array [i]}");
    }
}

int size = input ("введите размер массива  ");
int [] numbers = new int[size];

FillArray(numbers);
PrintArray(numbers);

   
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) sum += numbers[i]; 
    }   

   Console.WriteLine($"Сумма четных чисел {sum}"); 
}

void Task38()
{
// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и 
// минимальным элементами массива

void FillArrayDouble(double [] array, int minValue = 100, int maxValue = 999)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round ((rnd.NextDouble()*1000), 2);
    }
}

void PrintArrayDouble (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array [i]}");
    }
}

int size = input ("введите размер массива  ");
double [] numbers = new double [size];

FillArrayDouble(numbers);
PrintArrayDouble(numbers);

double max = numbers [0];
double min = numbers [0];
    

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max) max = numbers [i]; 
        else if (numbers[i] < min) min = numbers [i];
    }   

   Console.WriteLine($"Разница значений максимума и минимума равна {max-min}");
    
 
}

   




Console.Clear();
int task = input ("Введите номер задачи ");
switch (task)
{
case 34:
      Task34();
      break;

case 36:
      Task36();
      break;
   
case 38:
      Task38();
      break;

Console.WriteLine("Введен неправильный номер задачи");
      break;
}