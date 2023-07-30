internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // recursive

        int result = 1;
        for (int i = 1; i < 5; i++)
        {
            result = result * 3;
        }

        Islemler islem = new();

        Console.WriteLine(result);
        Console.WriteLine(islem.expa(3, 4));

        // extension method

        string ifade = "Bu bir deneme cümlesidir.";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);

        Console.WriteLine(ifade.MakeUpperCase());

        string sonuc2 = ifade.MakeLowerCase();

        Console.WriteLine(sonuc2);

        int[] dizi = {9, 3, 6, 2, 1, 5, 0};

        dizi.SortArray();

        dizi.EkranaYazdir();

        Console.WriteLine(dizi[2].IsEvenNumber());

        Console.WriteLine(ifade.GetFirstCharacter());


        if (sonuc)
        {
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        }
    }
}

public class Islemler
{
    public int expa(int sayi, int us)
    {
        if (us < 2)
        {
            return sayi;
        }
        return expa(sayi, us - 1) * sayi;
    }
}

public static class Extension{

        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
}