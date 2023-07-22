// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    int[] sayilar = {2,6,4,7,8,1,3,5};

    foreach (var sayi in sayilar)
    {
        Console.WriteLine(sayi);
    }
    Console.WriteLine("************");

    Array.Sort(sayilar);

    foreach (var sayi in sayilar)
    {
        Console.WriteLine(sayi);
    }
    Console.WriteLine("************");
    Array.Clear(sayilar,2,2);

    foreach (var sayi in sayilar)
    {
        Console.WriteLine(sayi);
    }

    Array.Reverse(sayilar);

    Console.WriteLine("************");
    foreach (var sayi in sayilar)
    {
        Console.WriteLine(sayi);
    }
    Console.WriteLine("************");

    Console.WriteLine(Array.IndexOf(sayilar,2));

    Console.WriteLine("************");

    Array.Resize<int>(ref sayilar,9);

    sayilar[8] = 24;
    
    foreach (var sayi in sayilar)
    {
        Console.WriteLine(sayi);
    }
   