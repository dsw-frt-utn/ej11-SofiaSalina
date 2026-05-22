using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno a1 = new Alumno(1, "Rocio", 8.5);
        Alumno a2 = new Alumno(2, "Juan", 7.0);
        Alumno a3 = new Alumno(3, "Lourdes", 9.2);

        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

        Console.WriteLine("--- Lista de Alumnos ---");
        foreach (var alumno in casoList.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\n--- Buscar alumno 'Juan' ---");
        Alumno encontrado = casoList.BuscarPorNombre("Juan");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\n--- Buscar alumno 'Carlos' ---");
        Alumno noEncontrado = casoList.BuscarPorNombre("Carlos");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        Console.WriteLine("\n--- Eliminar a 'Rocio' y listar ---");
        casoList.EliminarAlumno(a1);
        foreach (var alumno in casoList.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\n--- Eliminar el primer elemento y listar ---");
        casoList.EliminarEnPosicion(0);
        foreach (var alumno in casoList.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDict = new CasoDictionary();

        Alumno a1 = new Alumno(101, "Sofia", 8.8);
        Alumno a2 = new Alumno(102, "Marcos", 6.5);
        Alumno a3 = new Alumno(103, "Lucia", 9.5);

        casoDict.AgregarAlumno(101, a1);
        casoDict.AgregarAlumno(102, a2);
        casoDict.AgregarAlumno(103, a3);

        Console.WriteLine("--- Diccionario de Alumnos ---");
        foreach (KeyValuePair<int, Alumno> elemento in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo: {elemento.Key} - {elemento.Value}");
        }

        Console.WriteLine("\n--- Buscar legajo 102 ---");
        Alumno encontrado = casoDict.BuscarPorClave(102);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\n--- Buscar legajo 455 ---");
        Alumno noEncontrado = casoDict.BuscarPorClave(455);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        Console.WriteLine("\n--- Eliminar legajo 101 y listar ---");
        casoDict.EliminarPorClave(101);
        foreach (var elemento in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo: {elemento.Key} - {elemento.Value}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("--- Pruebas de LINQ ---");
        Console.WriteLine($"\nPrimer libro: {casoLinq.GetPrimero().Titulo}");
        Console.WriteLine($"Último libro: {casoLinq.GetUltimo().Titulo}");
        Console.WriteLine($"\nSuma total de precios: {casoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"Promedio de precios: {casoLinq.GetPromedioPrecios():C}");
        Console.WriteLine("\nLibros con ID > 15:");
       
        foreach (var libro in casoLinq.GetListById())
        {
            Console.WriteLine($"{libro.Id} - {libro.Titulo}");
        }

        Console.WriteLine("\nLista de libros con formato moneda:");
        foreach (var linea in casoLinq.GetLibros())
        {
            Console.WriteLine(linea);
        }

        Libro masCaro = casoLinq.GetMayorPrecio();
        Console.WriteLine($"\nLibro más caro: {masCaro.Titulo} a {masCaro.Precio:C}");

        Libro masBarato = casoLinq.GetMenorPrecio();
        Console.WriteLine($"Libro más barato: {masBarato.Titulo} a {masBarato.Precio:C}");
        
        Console.WriteLine("\nLibros con precio mayor al promedio:");
        foreach (var libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"{libro.Titulo} ({libro.Precio:C})");
        }

        Console.WriteLine("\nLibros ordenados por título Z-A:");
        foreach (var libro in casoLinq.GetLibrosDescendente())
        {
            Console.WriteLine(libro.Titulo);
        }
    
    }
}
