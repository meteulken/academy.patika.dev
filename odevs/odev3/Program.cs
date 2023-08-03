Console.WriteLine("Pozitif Bir Sayi Girin : ");
            int sayi = int.Parse(Console.ReadLine());
            if(sayi<=0)
            {
               Console.WriteLine("Lütfen pozitif bir sayı girin : ");
               sayi = int.Parse(Console.ReadLine());
            }


            string[] kelimeler = new string[sayi];
            for (int i = 1; i <= sayi; i++)
            {
               Console.WriteLine(i + " .Kelimeyi Giriniz  :  ");
               string sayi2 = Console.ReadLine();
               kelimeler[i] = sayi2;



            }
            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {

               Console.WriteLine(item);
            }
            Console.ReadLine();