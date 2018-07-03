using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleMathLirary
{
    /// <summary>
    /// Klasa prostych obliczen matematycznych
    /// </summary>
    static class SimpleMath
    {
        private const double _PI = 3.14159265359f;

        /// <summary>
        /// Zwraca wartosc liczby PI
        /// </summary>
        /// <returns>liczba PI</returns>
        public static double Pi()
        {
            return _PI;
        }

        /// <summary>
        /// Podnoszenie liczby do kwadratu
        /// </summary>
        /// <param name="x">liczba</param>
        /// <returns>kwadrat liczby x</returns>
        public static double Pow(double x)
        {
            return x * x;
        }

        /// <summary>
        /// Oblicza pole kola (okregu) o zadanym promieniu
        /// </summary>
        /// <param name="r">promien kola</param>
        /// <returns>pole kola o promieniu r</returns>
        public static double CircleArea(double r)
        {
            return Pi() * Pow(r);
        }
    }
}
