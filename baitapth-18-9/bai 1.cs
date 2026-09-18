using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];
        int tong = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap a[" + i + "]: ");
            a[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            tong = tong + a[i];
        }

        Console.WriteLine("Tong cac phan tu = " + tong);
    }
}