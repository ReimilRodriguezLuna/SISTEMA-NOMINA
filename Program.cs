using System;
using System.Collections.Generic;
using System.Linq;



class Puesto
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Puesto> puestos = new List<Puesto>();

        // Agregar puestos principales a la lista
        puestos.Add(new Puesto { Nombre = "Gerente de Proyectos", Descripcion = "Responsable de la gestión de proyectos de software" });
        puestos.Add(new Puesto { Nombre = "Desarrollador de Software", Descripcion = "Responsable del desarrollo y mantenimiento del software" });
        puestos.Add(new Puesto { Nombre = "Ingeniero de Calidad de Software", Descripcion = "Responsable de garantizar la calidad del software" });
        puestos.Add(new Puesto { Nombre = "Analista de datos", Descripcion = "Convertir datos en informacion,informacion en ideas e ideas en decisiones comerciales" });
        puestos.Add(new Puesto { Nombre = "ingeniero en sistema", Descripcion = "Diseño,implementacion evaluacion y mantenimiento de los sistemas informaticos" });

        {

        }
        // Imprimir todos los puestos en la consola
        foreach (Puesto puesto in puestos)
        {
            Console.WriteLine("Nombre del puesto: " + puesto.Nombre);
            Console.WriteLine("Descripción del puesto: " + puesto.Descripcion);
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
