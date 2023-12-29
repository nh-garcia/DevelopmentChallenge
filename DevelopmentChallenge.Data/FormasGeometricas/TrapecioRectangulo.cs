using System;

namespace DevelopmentChallenge.Data
{
    public class TrapecioRectangulo : IFormaGeometrica
    {
        public const int TIPO = 4;
        public int Tipo { get => TIPO; }

        private decimal _baseMayor;
        private decimal _baseMenor;
        private decimal _altura;

        public TrapecioRectangulo(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
        }

        public decimal CalcularArea()
        {
            return (_baseMayor + _baseMenor) * _altura / 2;
        }

        public decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + _altura + CalcularCateto();
        }

        private decimal CalcularCateto()
        {
            return (decimal)Math.Sqrt(Math.Pow((double)(_baseMayor - _baseMenor), 2) + Math.Pow((double)_altura, 2));
        }
    }
}
