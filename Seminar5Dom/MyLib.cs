using System;

namespace MyLib
{
public static class MyLibClass
{
    public static int input(string text)
        {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
        }

    public static void TestMethod ()
        {
            Console.WriteLine ("тест слово");
        }

    }
}    