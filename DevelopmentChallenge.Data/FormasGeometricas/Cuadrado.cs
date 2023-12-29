namespace DevelopmentChallenge.Data
{
    public class Cuadrado : IFormaGeometrica
    {
        public const int TIPO = 1;
        public int Tipo { get => TIPO; }

        private decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
