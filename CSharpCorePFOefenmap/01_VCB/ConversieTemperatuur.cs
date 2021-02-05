using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        const float GemLichTempCelsius = 37.0F;
        static void Main(string[] args)
        {
            float gemLichtTempFahrenheit =
                GemLichTempCelsius * 9.0F / 5.0F + 32.0F;
            Console.WriteLine("Gem. lichaamstemperatuur in graden " +
                "Celsius: " + GemLichTempCelsius );
            Console.WriteLine("Gem. lichaamstemperatuur in graden " +
                "Fahrenheit: " + gemLichtTempFahrenheit );
        }
    }
}
