// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//switch-case

int time = DateTime.Now.Month;


switch(time)
{
    case 1:
        Console.WriteLine("Ocak");
        break;
    case 2:
        Console.WriteLine("Şubat");
        break;
    case 3:
        Console.WriteLine("Mart");
        break;
    default:
        Console.WriteLine("Bilinmeyen ay");
        break;
}

switch(time)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kiş");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar");
        break;
    default:
        Console.WriteLine("Bilinmeyen ay");
        break;
}