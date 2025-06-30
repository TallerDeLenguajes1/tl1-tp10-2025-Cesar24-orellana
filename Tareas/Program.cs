using Tareas;
using ApiNsp;

List<Tarea> ListaTareas = await API.GetDatos();
foreach (var Tarea in ListaTareas)
{
    Console.WriteLine(Tarea.Title);
}