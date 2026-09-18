using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        Console.Write("Nhap ky tu can dem: ");
        char kytu = char.Parse(Console.ReadLine());

        int dem = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == kytu)
            {
                dem++;
            }
        }

        Console.WriteLine("So lan xuat hien = " + dem);
    }
}