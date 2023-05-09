using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace currencyConverter_oop
{
    public static class CurrencyConverter
    {
        private static float MultiplicadorRealParaDolar = 0.2f;
        private static float MultiplicadorDolarParaReal = 5.44f;

        public static float RealParaDolar(float real)
        {
            return real * MultiplicadorRealParaDolar;
        } 
        public static float DolarParaReal(float dolar)
        {
            return dolar * MultiplicadorDolarParaReal;
        } 
    }
}