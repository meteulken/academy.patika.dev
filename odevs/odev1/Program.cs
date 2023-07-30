// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int sayi = 0;
int sayi3 = 0;

Console.Write("Lütfen bir sayi giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());
int[] sayi2 = new int[sayi +1];
for (int i = 0; i <= sayi; i++)
{
    sayi3 = Convert.ToInt32(Console.ReadLine());
    sayi2[i] = sayi3;   
}
Console.WriteLine("Çift sayilar: ");

for (int i = 0; i <= sayi; i++)
{
    if(sayi2[i] % 2 == 0)
        Console.WriteLine(sayi2[i]);
}
