// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i = 1;
int toplam = 0;
Console.Write("Bir sayı giriniz : ");
int sayi = int.Parse(Console.ReadLine());


while (i <= sayi)
{
    toplam += i;
    i++;
}
    toplam /= sayi;
    Console.WriteLine("Ortalama : " + toplam);

    char c = 'a';
    while(c <= 'z')
    {
        Console.Write(c);
        c++;
    }

    // ************ FOREACH ************

    string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};

    foreach (var araba in arabalar)
    {
        Console.WriteLine(araba);
        
    }
