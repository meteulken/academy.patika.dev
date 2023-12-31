﻿namespace otomobils;


class Program
{
    static void Main()
    {
        Console.WriteLine("Interface");

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

        Console.WriteLine("Abstract Class");

        Corolla corolla = new Corolla();
        Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
        Console.WriteLine(corolla.KacTekerlektenOlusur());
        Console.WriteLine(corolla.StandartRengiNe().ToString());

        Console.WriteLine("------------------");

        NewFocus focus1 = new NewFocus();
        Console.WriteLine(focus1.HangiMarkaninAraci().ToString());
        Console.WriteLine(focus1.KacTekerlektenOlusur());
        Console.WriteLine(focus1.StandartRengiNe().ToString());

        Console.WriteLine("------------------");

        NewCivic civic1 = new NewCivic();
        Console.WriteLine(civic1.HangiMarkaninAraci().ToString());
        Console.WriteLine(civic1.KacTekerlektenOlusur());
        Console.WriteLine(civic1.StandartRengiNe().ToString());

        Console.WriteLine("------------------");

        NewCorolla corolla1 = new NewCorolla();
        Console.WriteLine(corolla1.HangiMarkaninAraci().ToString());
        Console.WriteLine(corolla1.KacTekerlektenOlusur());
        Console.WriteLine(corolla1.StandartRengiNe().ToString());


    }
}


