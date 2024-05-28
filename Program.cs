
using EspacioEmpleado;

Empleado primerEmpleado = new Empleado();

Console.WriteLine("Ingrese el nombre del empleado: ");
primerEmpleado.guardarNombre(Console.ReadLine());

Console.WriteLine(primerEmpleado.nombre);