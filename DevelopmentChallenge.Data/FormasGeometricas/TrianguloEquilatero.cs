using System;

namespace DevelopmentChallenge.Data
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        public const int TIPO = 2;
        public int Tipo { get => TIPO; }

        private decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
    }
}
