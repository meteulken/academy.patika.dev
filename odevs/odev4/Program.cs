            Console.WriteLine("Cümle yazınız.");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            int w = words.Count();
            char[] c = input.Replace(" ", string.Empty).ToCharArray();
            int c1 = c.Count();
            Console.WriteLine("Kelime sayısı: {0},Harf sayısı: {1}", w, c1);
            Console.ReadKey();