// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(DateTime.Now); // Şu anki zamanı verir
Console.WriteLine(DateTime.Now.Date); // Şu anki tarihi verir
Console.WriteLine(DateTime.Now.Day); // Ayın kaçıncı günü olduğunu verir
Console.WriteLine(DateTime.Now.Month); // Ayın kaçıncı ay olduğunu verir
Console.WriteLine(DateTime.Now.Year); // Yıl bilgisini verir
Console.WriteLine(DateTime.Now.Hour); // Saat bilgisini verir
Console.WriteLine(DateTime.Now.Minute); // Dakika bilgisini verir
Console.WriteLine(DateTime.Now.Second); // Saniye bilgisini verir

Console.WriteLine(DateTime.Now.DayOfWeek); // Haftanın hangi günü olduğunu verir
Console.WriteLine(DateTime.Now.DayOfYear); // Yılın kaçıncı günü olduğunu verir

Console.WriteLine(DateTime.Now.ToLongDateString()); // 30 Temmuz 2023 Pazar
Console.WriteLine(DateTime.Now.ToShortDateString()); // 30.07.2023
Console.WriteLine(DateTime.Now.ToLongTimeString()); // 16:19:36
Console.WriteLine(DateTime.Now.ToShortTimeString()); // 16:19

Console.WriteLine(DateTime.Now.AddDays(2)); // 2 gün sonrası
Console.WriteLine(DateTime.Now.AddHours(3)); // 3 saat sonrası
Console.WriteLine(DateTime.Now.AddMinutes(30)); // 30 dakika sonrası
Console.WriteLine(DateTime.Now.AddSeconds(15)); // 15 saniye sonrası
Console.WriteLine(DateTime.Now.AddMilliseconds(250)); // 250 milisaniye sonrası
Console.WriteLine(DateTime.Now.AddYears(5)); // 5 yıl sonrası

// DateTime Format

Console.WriteLine(DateTime.Now.ToString("dd")); // 30
Console.WriteLine(DateTime.Now.ToString("ddd")); // Paz
Console.WriteLine(DateTime.Now.ToString("dddd")); // Pazar

Console.WriteLine(DateTime.Now.ToString("MM")); // 07
Console.WriteLine(DateTime.Now.ToString("MMM")); // Tem
Console.WriteLine(DateTime.Now.ToString("MMMM")); // Temmuz

Console.WriteLine(DateTime.Now.ToString("yy")); // 23
Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2023

// Math Kütüphanesi

Console.WriteLine(Math.Abs(-25)); // 25
Console.WriteLine(Math.Sin(10)); // -0.5440211108893698
Console.WriteLine(Math.Cos(10)); // -0.8390715290764524
Console.WriteLine(Math.Tan(10)); // 0.6483608274590866

Console.WriteLine(Math.Ceiling(22.3)); // 23
Console.WriteLine(Math.Round(22.3)); // 22
Console.WriteLine(Math.Round(22.7)); // 23
Console.WriteLine(Math.Floor(22.7)); // 22

Console.WriteLine(Math.Max(2, 6)); // 6
Console.WriteLine(Math.Min(2, 6)); // 2

Console.WriteLine(Math.Pow(3, 4)); // 81
Console.WriteLine(Math.Sqrt(9)); // 3
Console.WriteLine(Math.Log(9)); // 2.1972245773362196
Console.WriteLine(Math.Exp(3)); // 20.085536923187668
Console.WriteLine(Math.Log10(10)); // 1

// Random Kütüphanesi

Random random = new Random();

Console.WriteLine(random.Next(1, 100)); // 1 ile 100 arasında rastgele bir sayı üretir
Console.WriteLine(random.Next(100)); // 0 ile 100 arasında rastgele bir sayı üretir

