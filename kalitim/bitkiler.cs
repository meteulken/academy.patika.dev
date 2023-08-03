
// bitkiler.cs(12,16): error CS1520: Yöntemin bir dönüş türü olmalıdır
// çözüm: TohumlaCogalma() methodunun dönüş tipi void olmalı.

    public class Bitkiler : Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak(); // base class'ın methodunu çağırmak için kullanılır.
        } 
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }


    public class TohumsuzBitkiler : Bitkiler
    {
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }
