
// kalıtım (inheritance) : bir sınıfın başka bir sınıftan özelliklerini miras almasıdır.

// base class : miras veren sınıf
// derived class : miras alan sınıf

    TohumluBitkiler tohumluBitki = new TohumluBitkiler();
    tohumluBitki.Beslenme();
    tohumluBitki.Solunum();
    tohumluBitki.Bosaltim();
    tohumluBitki.
    tohumluBitki.TohumlaCogalma();

    Console.WriteLine("***************");

    Kuslar marti = new Kuslar();
    marti.Beslenme();
    marti.Solunum();
    marti.Bosaltim();
    marti.Ucmak();

    Console.WriteLine("***************");

    Surungenler kurbaga = new Surungenler();
    kurbaga.Beslenme();
    kurbaga.Solunum();
    kurbaga.Bosaltim();
    kurbaga.SurunerekHareketEderler();
