using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        const int AantalSecondenInEenUur = 3600;
        const int AantalSecondenInEenMinuut = 60;
        static void Main(string[] args)
        {
            int totaalAantalSeconden = 3736;
            int uren, minuten, seconden, restseconden;
            uren = totaalAantalSeconden / AantalSecondenInEenUur;
            restseconden = totaalAantalSeconden % AantalSecondenInEenUur;
            minuten = restseconden / AantalSecondenInEenMinuut;
            seconden = restseconden % AantalSecondenInEenMinuut;
            Console.WriteLine("U:" + uren + " M" + minuten + " :S" + seconden);
            }
    }
}