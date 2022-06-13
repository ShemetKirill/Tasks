int k = 10;
int a;
int b;
a = Kata.Solution(k);
Console.WriteLine(a);
b = Kata1.Solution1(k);
Console.WriteLine(b);


public static class Kata
{
    public static int Solution(int value)
    {
        return Enumerable.Range(0, value).Where(x => x % 3 == 0 | x % 5 == 0).Sum();
    }
}

public static class Kata1
{
    public static int Solution1(int value)
    {
        int result = 0;
        for (int i = 0; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                result += i;
            }
        }
        return result;
    }
}