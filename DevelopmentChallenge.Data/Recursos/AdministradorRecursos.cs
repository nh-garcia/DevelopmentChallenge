using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace DevelopmentChallenge.Data
{
    public class AdministradorRecursos
    {
        private string GetRecurso(string nombreArchivo)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var nombreRecurso = $"DevelopmentChallenge.Data.Recursos.{nombreArchivo}";

            using (Stream stream = assembly.GetManifestResourceStream(nombreRecurso))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private T GetRecurso<T>(string nombreArchivo)
        {
            string json = GetRecurso(nombreArchivo);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public FormaGeometricaReporteTextos GetFormaGeometricaReporteTextos(Idioma idioma)
        {
            return GetRecurso<FormaGeometricaReporteTextos>($"formaGeometricaReporte_{idioma.Codigo}.json");
        }
    }
}
