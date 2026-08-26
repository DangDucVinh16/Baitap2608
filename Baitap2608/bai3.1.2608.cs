using System;

class Program
{
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

    static void Main()
    {
        Console.Write("Nhap so thu nhat a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap so thu hai b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap phep toan (+, -, *, /, %): ");
        char op = char.Parse(Console.ReadLine());

        try
        {
            double result = Calculate(a, b, op);
            Console.WriteLine($"Ket qua: {result:F2}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Loi: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Loi: {ex.Message}");
        }
    }
}
