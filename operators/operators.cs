using System;

namespace operatorlar;

class program
{   
    static void Main(string[] args)
    {
        // Aritmetik operatörler oluşturulan değişkenler üzerinde işlem yapar. 
        // Toplama, çıkarma, çarpma, bölme, mod alma ve arttırma işlemleri yapılabilir.
        int a = 10;
        int b = 5;
        int c = a + b; // 15
        int d = a - b; // 5
        int e = a * b; // 50
        int f = a / b; // 2
        int g = a % b; // 0
        int h = a++; // 10
        int i = ++a; // 12
        int j = a--; // 12
        int k = --a; // 10
        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);
        Console.WriteLine("c: " + c);
        Console.WriteLine("d: " + d);
        Console.WriteLine("e: " + e);
        Console.WriteLine("f: " + f);
        Console.WriteLine("g: " + g);
        Console.WriteLine("h: " + h);
        Console.WriteLine("i: " + i);
        Console.WriteLine("j: " + j);
        Console.WriteLine("k: " + k);

        // İlişkisel operatörler iki değişken arasında ilişki kurar.
        // İki değişkenin eşit olup olmadığını, büyük veya küçük olup olmadığını kontrol eder.
        int l = 10;
        int m = 5;
        bool n = l == m; // false
        bool o = l != m; // true
        bool p = l > m; // true
        bool q = l < m; // false
        bool r = l >= m; // true
        bool s = l <= m; // false
        Console.WriteLine("l: " + l);
        Console.WriteLine("m: " + m);
        Console.WriteLine("n: " + n);
        Console.WriteLine("o: " + o);
        Console.WriteLine("p: " + p);
        Console.WriteLine("q: " + q);
        Console.WriteLine("r: " + r);
        Console.WriteLine("s: " + s);

        // Mantıksal operatörler iki veya daha fazla koşulun birlikte kontrol edilmesini sağlar.
        // İki koşulun birlikte sağlanıp sağlanmadığını, bir koşulun sağlanıp diğerinin sağlanmadığını kontrol eder.
        bool t = true;
        bool u = false;
        bool v = t && u; // false
        bool w = t || u; // true
        bool x = !t; // false
        bool y = !u; // true
        Console.WriteLine("t: " + t);
        Console.WriteLine("u: " + u);
        Console.WriteLine("v: " + v);
        Console.WriteLine("w: " + w);
        Console.WriteLine("x: " + x);
        Console.WriteLine("y: " + y);

        if(t && !u)
        {
            Console.WriteLine("t true ve u false");
        }
        if(t || u)
        {
            Console.WriteLine("t = true veya u false değil");
        }
        if(t && u)
        {
            Console.WriteLine("t true ve u false");
        }

        // ilişkisel operatörler 
        // == eşitse
        // != eşit değilse
        // > büyükse
        // < küçükse
        // >= büyük veya eşitse
        // <= küçük veya eşitse

        int a1 = 10;
        int b1 = 5;
        bool c1 = a1 == b1; // false
        bool d1 = a1 != b1; // true
        bool e1 = a1 > b1; // true
        bool f1 = a1 < b1; // false
        bool g1 = a1 >= b1; // true
        bool h1 = a1 <= b1; // false
        Console.WriteLine("a1: " + a1);
        Console.WriteLine("b1: " + b1);
        Console.WriteLine("c1: " + c1);
        Console.WriteLine("d1: " + d1);
        Console.WriteLine("e1: " + e1);
        Console.WriteLine("f1: " + f1);
        Console.WriteLine("g1: " + g1);
        Console.WriteLine("h1: " + h1);

        

        
    }
}