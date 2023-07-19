// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//try catch
try
{
    Console.WriteLine("bir sayi giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("girmiş olduğunuz sayi: " + sayi);
}
// catch (Exception ex)
// {
//     Console.WriteLine("hata oluştu" + ex.Message.ToString());
// }
catch(ArgumentException ex)
{
    Console.WriteLine("hata oluştu" + ex.Message.ToString());
}
catch (FormatException ex)
{
    Console.WriteLine("hata oluştu" + ex.Message.ToString());
}
catch (OverflowException ex)
{
    Console.WriteLine("hata oluştu" + ex.Message.ToString());
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("hata oluştu" + ex.Message.ToString());
}
finally
{
    Console.WriteLine("işlem tamamlandı");
}


