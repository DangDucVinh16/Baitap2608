using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            ShowMenu();
            choice = ReadMenuChoice();

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    RunCalculator();
                    Pause();
                    break;

                case 2:
                    Console.Clear();
                    RunQuadraticEquation();
                    Pause();
                    break;

                case 3:
                    Console.Clear();
                    RunPrimeAndFibonacci();
                    Pause();
                    break;

                case 0:
                    Console.WriteLine("\nDa thoat chuong trinh. Tam biet!");
                    break;

                default:
                    Console.WriteLine("\nLua chon khong hop le! Nhan phim bat ky de thu lai...");
                    Console.ReadKey();
                    break;
            }

        } while (choice != 0);
    }

    // ================== MENU HELPERS ==================

    static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("=========================================");
        Console.WriteLine("           CHUONG TRINH BAI TAP           ");
        Console.WriteLine("=========================================");
        Console.WriteLine("1. Chay Bai tap 1 (Calculator)");
        Console.WriteLine("2. Chay Bai tap 2 (Phuong trinh bac 2)");
        Console.WriteLine("3. Chay Bai tap 3 (So nguyen to & Fibonacci)");
        Console.WriteLine("0. Thoat chuong trinh");
        Console.WriteLine("=========================================");
        Console.Write("Nhap lua chon cua ban: ");
    }

    static int ReadMenuChoice()
    {
        while (!int.TryParse(Console.ReadLine(), out int result))
        {
            Console.Write("Vui long nhap mot so nguyen hop le: ");
        }
        return result;
    }

    static void Pause()
    {
        Console.WriteLine("\nNhan phim bat ky de quay lai Menu...");
        Console.ReadKey();
    }

    // bai 1

    static void RunCalculator()
    {
        Console.WriteLine("----- BAI TAP 1: CALCULATOR -----\n");

        double a = ReadDouble("Nhap so thu nhat a: ");
        double b = ReadDouble("Nhap so thu hai b: ");

        Console.Write("Nhap phep toan (+, -, *, /, %): ");
        char op = char.Parse(Console.ReadLine());

        try
        {
            double result = Calculate(a, b, op);
            Console.WriteLine($"\nKet qua: {result:F2}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"\nLoi: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nLoi: {ex.Message}");
        }
    }

    static double Calculate(double a, double b, char op)
    {
        return op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' when b == 0 => throw new DivideByZeroException("Khong the chia cho 0!"),
            '/' => a / b,
            '%' when b == 0 => throw new DivideByZeroException("Khong the chia lay du cho 0!"),
            '%' => a % b,
            _ => throw new ArgumentException($"Phep toan '{op}' khong hop le!")
        };
    }
    // bai 2
    static void RunQuadraticEquation()
    {
        Console.WriteLine("----- BAI TAP 2: PHUONG TRINH BAC 2 -----\n");

        double a = ReadDouble("Nhap he so a: ");
        double b = ReadDouble("Nhap he so b: ");
        double c = ReadDouble("Nhap he so c: ");

        Console.WriteLine();

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem.");
                else
                    Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phuong trinh bac nhat co nghiem: x = {x:F2}");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phuong trinh co 2 nghiem phan biet: x1 = {x1:F2}, x2 = {x2:F2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phuong trinh co nghiem kep: x = {x:F2}");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
        }
    }

    // bai 3

    static void RunPrimeAndFibonacci()
    {
        Console.WriteLine("----- BAI TAP 3: SO NGUYEN TO, SO HOAN HAO & FIBONACCI -----\n");

        int n = ReadPositiveInt("Nhap so nguyen duong N: ");

        Console.WriteLine();

        if (IsPerfectNumber(n))
            Console.WriteLine($"{n} la So hoan hao!");
        else
            Console.WriteLine($"{n} KHONG la So hoan hao!");

        if (IsPrime(n))
            Console.WriteLine($"{n} la So nguyen to.");
        else
            Console.WriteLine($"{n} KHONG la So nguyen to.");

        PrintFibonacci(n);
    }

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

    static double ReadDouble(string prompt)
    {
        double result;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Gia tri khong hop le, vui long nhap lai: ");
        }
        return result;
    }

    static int ReadPositiveInt(string prompt)
    {
        int result;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
        {
            Console.Write("Vui long nhap mot so nguyen duong hop le: ");
        }
        return result;
    }
}