
// bitkiler.cs(12,16): error CS1520: Yöntemin bir dönüş türü olmalıdır
// çözüm: TohumlaCogalma() methodunun dönüş tipi void olmalı.

    public class Bitkiler : Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void UyaranlaraTepki()
        {
            // base.UyaranlaraTepki(); // base class'ın methodunu çağırmak için kullanılır.
            Console.WriteLine("Bitkiler güneşe tepki verir."); // override edilen methodun içeriği değiştirilir.
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak(); // base class'ın methodunu çağırmak için kullanılır.
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        } 
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }


    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }