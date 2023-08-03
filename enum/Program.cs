// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// enum (enumeration) -> belirli bir veri tipinin değişkenlerini tanımlamak için kullanılır.

// enum tanımlama

enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

// enum kullanımı

Days day = Days.Monday;

Console.WriteLine(day);


// enum içerisindeki değerleri değiştirme

enum Months
{
    January = 1,
    February = 2,
    March = 3,
    April = 4,
    May = 5,
    June = 6,
    July = 7,
    August = 8,
    September = 9,
    October = 10,
    November = 11,
    December = 12
}

Months month = Months.January;