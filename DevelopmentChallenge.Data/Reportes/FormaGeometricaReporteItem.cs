namespace DevelopmentChallenge.Data
{
    public class FormaGeometricaReporteItem
    {
        public int TipoForma { get; set; }
        public int Cantidad { get; set; } = 0;
        public decimal Area { get; set; } = 0;
        public decimal Perimetro { get; set; } = 0;

        public FormaGeometricaReporteItem(int tipoForma)
        {
            TipoForma = tipoForma;
        }

        public string ObtenerNombre(FormaGeometricaReporteTextos textos)
        {
            switch (TipoForma)
            {
                case Cuadrado.TIPO:
                    return Cantidad == 1 ? textos.Cuadrado : textos.Cuadrados;
                case Circulo.TIPO:
                    return Cantidad == 1 ? textos.Circulo : textos.Circulos;
                case TrianguloEquilatero.TIPO:
                    return Cantidad == 1 ? textos.Triangulo : textos.Triangulos;
                case TrapecioRectangulo.TIPO:
                    return Cantidad == 1 ? textos.Trapecio : textos.Trapecios;
            }

            return string.Empty;
        }
    }
}
