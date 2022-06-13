using System;

int a = 2;
int b = 1;
string c = Kata.AddBinary(a, b);
Console.WriteLine(c);

public static class Kata
{
    public static string AddBinary(int a, int b)
    {
        return Convert.ToString(a + b, 2);
    }
}