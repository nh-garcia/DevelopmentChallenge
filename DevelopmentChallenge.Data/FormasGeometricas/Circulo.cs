using System;

namespace DevelopmentChallenge.Data
{
    public class Circulo : IFormaGeometrica
    {
        public const int TIPO = 3;
        public int Tipo { get => TIPO; }

        private decimal _diametro;

        public Circulo(decimal diametro)
        {
            _diametro = diametro;
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _diametro;
        }
    }
}
