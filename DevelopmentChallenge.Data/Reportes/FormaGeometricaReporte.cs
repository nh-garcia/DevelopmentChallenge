using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data
{
    public class FormaGeometricaReporte
    {
        public static string Imprimir(List<IFormaGeometrica> formas, Idioma idioma)
        {
            var textos = new AdministradorRecursos().GetFormaGeometricaReporteTextos(idioma);

            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{textos.ListaVacia}</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append($"<h1>{textos.Titulo}</h1>");

                var items = new List<FormaGeometricaReporteItem>()
                {
                    new FormaGeometricaReporteItem(Cuadrado.TIPO),
                    new FormaGeometricaReporteItem(Circulo.TIPO),
                    new FormaGeometricaReporteItem(TrianguloEquilatero.TIPO),
                    new FormaGeometricaReporteItem(TrapecioRectangulo.TIPO)
                };

                foreach (var forma in formas)
                {
                    foreach (var item in items)
                    {
                        if (forma.Tipo == item.TipoForma)
                        {
                            item.Cantidad++;
                            item.Area += forma.CalcularArea();
                            item.Perimetro += forma.CalcularPerimetro();
                        }
                    }
                }

                items.ForEach(item =>
                {
                    sb.Append(ObtenerLinea(item, textos));
                });

                // FOOTER
                sb.Append($"{textos.Total}<br/>");

                sb.Append(items.Sum(x => x.Cantidad) + " " + textos.Formas);
                sb.Append(textos.Perimetro + items.Sum(x => x.Perimetro).ToString("#.##") + " ");
                sb.Append(textos.Area + items.Sum(x => x.Area).ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(FormaGeometricaReporteItem item, FormaGeometricaReporteTextos textos)
        {
            if (item.Cantidad > 0)
            {
                return $"{item.Cantidad} {item.ObtenerNombre(textos)} | {textos.Area}{item.Area:#.##} | {textos.Perimetro}{item.Perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

    }
}
