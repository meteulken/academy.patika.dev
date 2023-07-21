// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    Console.WriteLine("Sayı giriniz: ");
    int sayi = int.Parse(Console.ReadLine());
    int tektoplam = 0;
    int cifttoplam = 0;


        for (int j = 0; j <= 1000; j++)
        {
            if(j % 2 == 0)
            {
                cifttoplam += j;
            }
            else
            {
                tektoplam += j;
            }
        }
        Console.WriteLine("Tek Toplam: " + tektoplam);
        Console.WriteLine("Çift Toplam: " + cifttoplam);

        // break, continue
        for (int i = 1; i < 10; i++)
        {
            if(i == 4)
            {
                break;
            }
            Console.WriteLine(i);
        }

        for (int i = 1; i < 10; i++)
        {
            if(i == 4)
            {
                continue;
            }
            Console.WriteLine(i);
        } 