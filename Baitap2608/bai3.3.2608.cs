using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static bool IsPerfectNumber(int n)
    {
        if (n < 2) return false;

        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
                sum += i;
        }
        return sum == n;
    }

    static void PrintFibonacci(int n)
    {
        long a = 0, b = 1;
        int count = 0;

        Console.Write($"Day Fibonacci {n} so: ");
        while (count < n)
        {
            Console.Write(a);
            if (count < n - 1) Console.Write(", ");

            long next = a + b;
            a = b;
            b = next;
            count++;
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Nhap so nguyen duong N: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("N phai la so nguyen duong!");
            return;
        }

        if (IsPerfectNumber(n))
            Console.WriteLine($"{n} là So hoan hao!");
        else
            Console.WriteLine($"{n} KHONG la So hoan hao!");

        if (IsPrime(n))
            Console.WriteLine($"{n} là So nguyen to.");
        else
            Console.WriteLine($"{n} KHONG la So nguyen to.");

        PrintFibonacci(n);
    }
}
