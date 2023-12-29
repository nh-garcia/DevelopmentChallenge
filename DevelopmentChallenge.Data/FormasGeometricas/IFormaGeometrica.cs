namespace DevelopmentChallenge.Data
{
    public interface IFormaGeometrica
    {
        int Tipo { get; }

        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}