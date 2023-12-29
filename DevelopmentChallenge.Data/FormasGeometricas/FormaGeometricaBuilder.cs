namespace DevelopmentChallenge.Data
{
    public class FormaGeometricaBuilder
    {
        public IFormaGeometrica GetCuadrado(int lado)
        {
            return new Cuadrado(lado);
        }

        public IFormaGeometrica GetCirculo(decimal diametro)
        {
            return new Circulo(diametro);
        }

        public IFormaGeometrica GetTrianguloEquilatero(decimal lado)
        {
            return new TrianguloEquilatero(lado);
        }

        public IFormaGeometrica GetTrapecioRectangulo(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            return new TrapecioRectangulo(baseMayor, baseMenor, altura);
        }
    }
}
