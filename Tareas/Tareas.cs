using System.Text.Json.Serialization;
namespace Tareas
{
    public class Tarea
    {
        private int _userId;
        private int _id;
        private string? _titulo; //PUEDE SER CUALQUIER NOMBRE
        private bool _complado;

        [JsonPropertyName("userId")] //No es necesario si el public int es igual al nombre del dato del API
        public int UserId { get => _userId; set => _userId = value; }
        [JsonPropertyName("id")]
        public int Id { get => _id; set => _id = value; }
        [JsonPropertyName("title")]
        public string? Title { get => _titulo; set => _titulo = value; }
        [JsonPropertyName("completed")]
        public bool Completed { get => _complado; set => _complado = value; }
    }
}