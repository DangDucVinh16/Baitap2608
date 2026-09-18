using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        string dao = "";

        for (int i = s.Length - 1; i >= 0; i--)
        {
            dao = dao + s[i];
        }

        Console.WriteLine("Chuoi dao nguoc = " + dao);
    }
}