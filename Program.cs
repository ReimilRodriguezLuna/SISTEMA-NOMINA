// DECLARACION DE VARIABLES Y ESTRUCTURA DE DATOS DE NOMINA

using System;

class Program
{
    static void Main(string[] args)
    {
        //Declaración de variables
        string nombreEmpleado;
        int idEmpleado;
        double salarioMensual;
        double impuestoSobreSalario;
        double totalSalario;

        //Solicitar información al usuario
        Console.Write("Ingrese el nombre del empleados femeninas: ");
        nombreEmpleado = Console.ReadLine();
        Console.Write("Ingrese el nombre del empleados en Licencia Medica: ");
        nombreEmpleado = Console.ReadLine();
        Console.Write("Ingrese el ID del empleado: ");
        idEmpleado = Int32.Parse(Console.ReadLine());
        Console.Write("Ingrese el salario mensual del empleado : ");
        salarioMensual = Double.Parse(Console.ReadLine());

        //Calcular impuesto sobre salario y salario neto
        impuestoSobreSalario = salarioMensual * 0.20;
        totalSalario = salarioMensual - impuestoSobreSalario;

        //Imprimir información de la nómina
        Console.WriteLine("Nombre del empleado: {0}", nombreEmpleado);
        Console.WriteLine("ID del empleado: {0}", idEmpleado);
        Console.WriteLine("Salario mensual: {0:C}", salarioMensual);
        Console.WriteLine("Impuesto sobre salario: {0:C}", impuestoSobreSalario);
        Console.WriteLine("Total salario: {0:C}", totalSalario);

        Console.ReadKey();
    }
}
