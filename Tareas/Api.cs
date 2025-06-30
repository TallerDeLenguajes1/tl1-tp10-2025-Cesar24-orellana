using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Tareas;

namespace ApiNsp
{
    public static class API
    {
        public static async Task<List<Tarea>> GetDatos()    //getDato nombre de la funcion EL METODO DEBE SET STATIC PQ LA CLASE LO ES
        {
            var url = "https://jsonplaceholder.typicode.com/todos/";
            HttpClient Cliente = new HttpClient();          // creamos el objeto de httpClient
            HttpResponseMessage Respuesta = await Cliente.GetAsync(url);     // obtiene los datos de la api
            Respuesta.EnsureSuccessStatusCode();        // avisa si llega algo o no
            string RespuestaString = await Respuesta.Content.ReadAsStringAsync();   // pasa a string los datos obtenidos en response
            List<Tarea> ListaTareas = JsonSerializer.Deserialize<List<Tarea>>(RespuestaString);      // transforma los datos del stirng al objeto usando la deserializacion
            return ListaTareas;
        }
    }
}