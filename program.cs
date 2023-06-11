using System;

class Program
{
    static void Main(string[] args)
    {
        // Tam sayılar
        int integerVariable = 10; // 4 byte
        long longVariable = 1000000; // 8 byte
        short shortVariable = 5; // 2 byte
        byte byteVariable = 255; // 1 byte

        // Ondalık sayılar
        float floatVariable = 3.14f; // 4 byte
        double doubleVariable = 3.14159; // 8 byte
        decimal decimalVariable = 3.14159265359m; // 16 byte

        // Metinler
        string stringVariable = "Merhaba, Dünya!";

        // Karakterler
        char charVariable = 'A'; // 2 byte

        // Mantıksal değerler
        bool boolVariable = true; // 1 byte

        // Tarih ve saat
        DateTime dateTimeVariable = DateTime.Now; // 8 byte

        // Diziler
        int[] arrayVariable = { 1, 2, 3, 4, 5 }; 

        // Nesneler
        object objectVariable = new object();
        object obj1 = 21;
        object obj2 = "Merhana";
        
        // Değişken dönüşümleri
        
        double num1 = 3.14;
        int num2 = (int)num1;
        float num3 = 2.5f;
        int num4 = Convert.ToInt32(num3);
        string str = num4.ToString();
        
        // Çıktılar

        Console.WriteLine("Tam sayı: " + integerVariable);
        Console.WriteLine("Ondalık sayı: " + floatVariable);
        Console.WriteLine("Metin: " + stringVariable);
        Console.WriteLine("Mantıksal: " + boolVariable);
        Console.WriteLine("Tarih ve saat: " + dateTimeVariable);
        Console.WriteLine("Dizi elemanı: " + arrayVariable[0]);
        Console.WriteLine("Nesne türü: " + objectVariable.GetType());

        Console.ReadLine();
    }
}
