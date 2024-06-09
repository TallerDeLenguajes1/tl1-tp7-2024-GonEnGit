
using EspacioEmpleado;

Empleado[] arreglo = new Empleado[3];
DateTime[] nacimientos = {new DateTime(1986, 2, 15), new DateTime(1990, 4, 21), new DateTime(1997, 9, 5) };
DateTime[] ingresos = {new DateTime(2015, 4, 20), new DateTime(2012, 5, 8), new DateTime(2020, 7, 21) };
char estado;
bool prueba;
string ingreso;
int valorCargo;
double valorSueldo;

for (int i = 0; i < 3; i++)
{
    valorSueldo = new Random().NextDouble() * 1000 + 5000;
    valorCargo = new Random().Next(1, 5);

    Console.WriteLine($"Ingrese el nombre del empleado N°{i}: ");
    arreglo[i].Nombre = Console.ReadLine();

    Console.WriteLine($"Ingrese el apellido del empleado N°{i}: ");
    arreglo[i].Apellido = Console.ReadLine();

    arreglo[i].Nacimiento = nacimientos[i];

    Console.WriteLine($"Ingrese el estado civil del empleado N°{i} (S/C): ");
    ingreso = Console.ReadLine();
    prueba = char.TryParse(ingreso, out estado);
    if (prueba)
    {
        arreglo[i].EstadoCivil = estado;
    }
    else
    {
        arreglo[i].EstadoCivil = 'S';
    }

    arreglo[i].IngresoAEmpresa = ingresos[i];

    arreglo[i].CargoDelEmpleado = (Empleado.cargo)valorCargo;
}

foreach (var item in arreglo)
{
    Console.WriteLine($"{item.Nombre}, {item.Apellido}, {item.CargoDelEmpleado}");
}

/* te está dando un error */ 