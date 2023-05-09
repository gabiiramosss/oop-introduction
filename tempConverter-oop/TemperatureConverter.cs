using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tempConverter_oop
{
    public static class TemperatureConverter
    {
        public static float CelsiusParaFahrenheit(float temperaturaCelsius)
        {
            float celsius = temperaturaCelsius;
            float fahrenheit = (celsius * 1.8f) + 32;
            return fahrenheit;
        }
        public static float FahrenheitParaCelsius(float temperaturaFahrenheit)
        {
            float fahrenheit = temperaturaFahrenheit;
            float celsius = (fahrenheit - 32) * .55f;
            return celsius;
        }
    }
}