using System.Collections.Generic;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometricaReporte.Imprimir(new List<IFormaGeometrica>(), Idiomas.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometricaReporte.Imprimir(new List<IFormaGeometrica>(), Idiomas.Ingles));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco forme vuoto!</h1>",
                FormaGeometricaReporte.Imprimir(new List<IFormaGeometrica>(), Idiomas.Italiano));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var builder = new FormaGeometricaBuilder();
            var cuadrados = new List<IFormaGeometrica> { builder.GetCuadrado(5) };

            var resumen = FormaGeometricaReporte.Imprimir(cuadrados, Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var builder = new FormaGeometricaBuilder();
            var cuadrados = new List<IFormaGeometrica>
            {
                builder.GetCuadrado(5),
                builder.GetCuadrado(1),
                builder.GetCuadrado(3)
            };

            var resumen = FormaGeometricaReporte.Imprimir(cuadrados, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioRectangulo()
        {
            var builder = new FormaGeometricaBuilder();
            var forma = new List<IFormaGeometrica> { builder.GetTrapecioRectangulo(10, 6, 8) };

            var resumen = FormaGeometricaReporte.Imprimir(forma, Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>" +
                "1 Trapecio | Area 64 | Perimetro 32,94 <br/>" +
                "TOTAL:<br/>1 formas Perimetro 32,94 Area 64", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioRectanguloIngles()
        {
            var builder = new FormaGeometricaBuilder();
            var forma = new List<IFormaGeometrica> { builder.GetTrapecioRectangulo(10, 6, 8) };

            var resumen = FormaGeometricaReporte.Imprimir(forma, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>" +
                "1 Trapeze | Area 64 | Perimeter 32,94 <br/>" +
                "TOTAL:<br/>1 shapes Perimeter 32,94 Area 64", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioRectanguloItaliano()
        {
            var builder = new FormaGeometricaBuilder();
            var forma = new List<IFormaGeometrica> { builder.GetTrapecioRectangulo(10, 6, 8) };

            var resumen = FormaGeometricaReporte.Imprimir(forma, Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto forme</h1>" +
                "1 Trapezio | Zona 64 | Perimetro 32,94 <br/>" +
                "TOTALE:<br/>1 forme Perimetro 32,94 Zona 64", resumen);
        }

        [TestCase]
        public void TestResumenListaConTrapeciosRectangulos()
        {
            var builder = new FormaGeometricaBuilder();
            var formas = new List<IFormaGeometrica> 
            { 
                builder.GetTrapecioRectangulo(10, 6, 8),
                builder.GetTrapecioRectangulo(5, 2, 3),
            };

            var resumen = FormaGeometricaReporte.Imprimir(formas, Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>" +
                "2 Trapecios | Area 74,5 | Perimetro 47,19 <br/>" +
                "TOTAL:<br/>2 formas Perimetro 47,19 Area 74,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConTrapeciosRectangulosIngles()
        {
            var builder = new FormaGeometricaBuilder();
            var formas = new List<IFormaGeometrica>
            {
                builder.GetTrapecioRectangulo(10, 6, 8),
                builder.GetTrapecioRectangulo(5, 2, 3),
            };

            var resumen = FormaGeometricaReporte.Imprimir(formas, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>" +
                "2 Trapezes | Area 74,5 | Perimeter 47,19 <br/>" +
                "TOTAL:<br/>2 shapes Perimeter 47,19 Area 74,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConTrapeciosRectangulosItaliano()
        {
            var builder = new FormaGeometricaBuilder();
            var formas = new List<IFormaGeometrica>
            {
                builder.GetTrapecioRectangulo(10, 6, 8),
                builder.GetTrapecioRectangulo(5, 2, 3),
            };

            var resumen = FormaGeometricaReporte.Imprimir(formas, Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto forme</h1>" +
                "2 Trapezi | Zona 74,5 | Perimetro 47,19 <br/>" +
                "TOTALE:<br/>2 forme Perimetro 47,19 Zona 74,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var builder = new FormaGeometricaBuilder();
            var formas = new List<IFormaGeometrica>
            {
                builder.GetCuadrado(5),
                builder.GetCirculo(3),
                builder.GetTrianguloEquilatero(4),
                builder.GetCuadrado(2),
                builder.GetTrianguloEquilatero(9),
                builder.GetCirculo(2.75m),
                builder.GetTrianguloEquilatero(4.2m),
                builder.GetTrapecioRectangulo(10, 6, 8)
            };

            var resumen = FormaGeometricaReporte.Imprimir(formas, Idiomas.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>" +
                "2 Squares | Area 29 | Perimeter 28 <br/>" +
                "2 Circles | Area 13,01 | Perimeter 18,06 <br/>" +
                "3 Triangles | Area 49,64 | Perimeter 51,6 <br/>" +
                "1 Trapeze | Area 64 | Perimeter 32,94 <br/>" +
                "TOTAL:<br/>8 shapes Perimeter 130,61 Area 155,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var builder = new FormaGeometricaBuilder();
            var formas = new List<IFormaGeometrica>
            {
                builder.GetCuadrado(5),
                builder.GetCirculo(3),
                builder.GetTrianguloEquilatero(4),
                builder.GetCuadrado(2),
                builder.GetTrianguloEquilatero(9),
                builder.GetCirculo(2.75m),
                builder.GetTrianguloEquilatero(4.2m),
                builder.GetTrapecioRectangulo(10, 6, 8)
            };

            var resumen = FormaGeometricaReporte.Imprimir(formas, Idiomas.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>" +
                "2 Cuadrados | Area 29 | Perimetro 28 <br/>" +
                "2 Círculos | Area 13,01 | Perimetro 18,06 <br/>" +
                "3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>" +
                "1 Trapecio | Area 64 | Perimetro 32,94 <br/>" +
                "TOTAL:<br/>8 formas Perimetro 130,61 Area 155,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var builder = new FormaGeometricaBuilder();
            var formas = new List<IFormaGeometrica>
            {
                builder.GetCuadrado(5),
                builder.GetCirculo(3),
                builder.GetTrianguloEquilatero(4),
                builder.GetCuadrado(2),
                builder.GetTrianguloEquilatero(9),
                builder.GetCirculo(2.75m),
                builder.GetTrianguloEquilatero(4.2m),
                builder.GetTrapecioRectangulo(10, 6, 8)
            };

            var resumen = FormaGeometricaReporte.Imprimir(formas, Idiomas.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto forme</h1>" +
                "2 Quadrati | Zona 29 | Perimetro 28 <br/>" +
                "2 Cerchi | Zona 13,01 | Perimetro 18,06 <br/>" +
                "3 Triangoli | Zona 49,64 | Perimetro 51,6 <br/>" +
                "1 Trapezio | Zona 64 | Perimetro 32,94 <br/>" +
                "TOTALE:<br/>8 forme Perimetro 130,61 Zona 155,65",
                resumen);
        }
    }
}
