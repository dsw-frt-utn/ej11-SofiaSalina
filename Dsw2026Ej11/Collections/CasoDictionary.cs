using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> diccionarioAlumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        diccionarioAlumnos.Add(legajo, alumno);
    }

    public Alumno BuscarPorClave(int legajo)
    {
        if (diccionarioAlumnos.ContainsKey(legajo))
        {
            return diccionarioAlumnos[legajo];
        }
        return null;
    }

    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return diccionarioAlumnos;
    }

    public void EliminarPorClave(int legajo)
    {
        diccionarioAlumnos.Remove(legajo);
    }
}
