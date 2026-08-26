using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap he so a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap he so b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap he so c: ");
        double c = double.Parse(Console.ReadLine());

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
}
