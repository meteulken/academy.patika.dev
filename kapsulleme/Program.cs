using System;

// encapsulation: kapsülleme demektir. Bir nesnenin fieldlarını private yaparak dışarıdan erişimi engellemek ve sadece istediğimiz fieldlara erişimi sağlamaktır.
// property: bir fieldın değerini okumak veya değiştirmek için kullanılan yapılardır. Propertyler bir fieldın değerini okumak veya değiştirmek için kullanılır.
// Propertylerin 2 tane özelliği vardır. Get ve Set. 
// Get: bir fieldın değerini okumak için kullanılır.
// Set: bir fieldın değerini değiştirmek için kullanılır.

    Ogrenci ogrenci1 = new Ogrenci();
    ogrenci1.Isim = "Ayşe";
    ogrenci1.Soyisim = "Yılmaz";
    ogrenci1.OgrenciNo = 123;
    ogrenci1.Sinif = 1;

    ogrenci1.SinifAtlat();
    ogrenci1.OgrenciBilgileriniGetir();


    Ogrenci ogrenci2 = new Ogrenci("Deniz", "Arda", 456, 1);
    ogrenci2.SinifDusur();
    ogrenci2.SinifDusur();
    ogrenci2.OgrenciBilgileriniGetir();






class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim { 
        get { return isim; }
        set { isim = value; }
    }

    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif
    { 
        get => sinif; 
        set 
        {
            if(value < 1)
            {
                Console.WriteLine("Sınıf en az 1 olabilir.");
                sinif = 1;
            }
            else
                sinif = value;
        }
    }

    public Ogrenci()
    {
        
    }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("Öğrenci Bilgileri");
        Console.WriteLine("İsim: {0}", this.Isim);
        Console.WriteLine("Soyisim: {0}", this.Soyisim);
        Console.WriteLine("Öğrenci No: {0}", this.OgrenciNo);
        Console.WriteLine("Sınıf: {0}", this.Sinif);
    }

    public void SinifAtlat()
    {
        this.Sinif = this.Sinif + 1;
    }

    public void SinifDusur()
    {
        this.Sinif = this.Sinif - 1;
    }
};
