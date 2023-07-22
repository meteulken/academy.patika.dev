internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // ************ DİZİLER ************
       
        int[] dizi;
        dizi = new int[5];

        string[] renkler = new string[5]; // Yönetilen string dizisi bildirimi

        string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

        dizi[3] = 10;
        renkler[0] = "Mavi";

        Console.WriteLine(dizi[3]);
        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(renkler[0]);

        // ************ DÖNGÜLER ************

        Console.Write("Lütfen dizinin eleman sayısını giriniz : ");
        int diziuzunluğu = int.Parse(Console.ReadLine());
        int[] sayilar = new int[diziuzunluğu];

        for(int i = 0; i < diziuzunluğu; i++)
        {
            Console.Write("Lütfen {0}. sayısı giriniz :", i + 1);
            sayilar[i] = int.Parse(Console.ReadLine());
        }
        
        int toplam = 0;
        foreach (var sayi in sayilar)
        {
            toplam += sayi;
        }
        Console.WriteLine("Ortalama :" + toplam/diziuzunluğu);


        } 
    }