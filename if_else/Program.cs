// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//if else


int time = DateTime.Now.Hour;

if(time < 12)
{
    Console.WriteLine("Good Morning");
}
else if(time < 18)
{
    Console.WriteLine("Good Afternoon");
}
else
{
    Console.WriteLine("Good Evening");
}

string sonuc = time <= 18 ? "Günaydin" : "iyi Aksamlar";
sonuc = time == 18 ? "iyi Aksamlar" : time < 12 ? "Günaydin" : "iyi Geceler";

Console.WriteLine(sonuc);

