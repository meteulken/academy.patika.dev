namespace otomobils;


class Program
{
    static void Main()
    {
        Focus focus = new Focus();
        Console.WriteLine(focus.HangiMarkaninAraci().ToString());
        Console.WriteLine(focus.KacTekerlektenOlusur());
        Console.WriteLine(focus.StandartRengiNe().ToString());

        Console.WriteLine("*************");

        Civic civic = new Civic();
        Console.WriteLine(civic.HangiMarkaninAraci().ToString());
        Console.WriteLine(civic.KacTekerlektenOlusur());
        Console.WriteLine(civic.StandartRengiNe().ToString());

        Console.WriteLine("*************");

        Corolla corolla = new Corolla();
        Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
        Console.WriteLine(corolla.KacTekerlektenOlusur());
        Console.WriteLine(corolla.StandartRengiNe().ToString());

    }
}


