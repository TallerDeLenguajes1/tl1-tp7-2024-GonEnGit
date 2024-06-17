
using EspacioEmpleado;

// tené cuidado, esto no está creando un arreglo con 3 objetos vacios
// esta linea solo crea un arreglo con 3 referencias a Empleado
// despues igual tenes que crear los 3 objetos
Empleado[] arreglo = new Empleado[3];

// DateOnly es la version de solo fecha de DateTime
// tambien existe 'TimeOnly' que es la version de solo
// hora de DateTime, todas son la misma estructura de DateTime
DateOnly[] nacimientos = {new DateOnly(1986, 2, 15), new DateOnly(1990, 4, 21), new DateOnly(1997, 9, 5) };
DateOnly[] ingresos = {new DateOnly(1998, 4, 20), new DateOnly(2010, 5, 8), new DateOnly(2020, 7, 21) };

/* variables */
char estado;
bool prueba;
string ingreso;
int valorCargo;
double valorSueldo;
double totalAPagar = 0;


/* cuerpo del programa */
for (int i = 0; i < 3; i++)
{
// aquí primero creas el objeto EMpleado y recien guardas los datos
// NOTA: si pones Empleado arreglo [i] = ... te dice que estas
// redefiniendo arreglo[i]
    arreglo[i] = new Empleado();
    valorSueldo = new Random().NextDouble() * 1000 + 5000;
    valorCargo = new Random().Next(1, 5);

    Console.WriteLine($"\nIngrese el nombre del empleado N°{i+1}: ");
    arreglo[i].Nombre = Console.ReadLine();

    Console.WriteLine($"Ingrese el apellido del empleado N°{i+1}: ");
    arreglo[i].Apellido = Console.ReadLine();

    arreglo[i].Nacimiento = nacimientos[i];

    Console.WriteLine($"Ingrese el estado civil del empleado N°{i+1} (S/C): ");
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

// usar el enum era mas facil de lo que parecia

// '(nombre del enum)numero' te devuelve el valor de enum
// guardado en la posicion 'numero'

// '(int)valor del enum' te devuelve el numero
// que corresponde al valor
    arreglo[i].CargoDelEmpleado = (Empleado.cargo)valorCargo;

    arreglo[i].Salario = arreglo[i].calcularSalario();
}

foreach (var item in arreglo)
{
    Console.WriteLine($"\nNombre: {item.Nombre}, {item.Apellido}");
    Console.WriteLine($"Nacido: {item.Nacimiento}, Ingresó: {item.IngresoAEmpresa}");
    if (item.EstadoCivil == 'S')
    {
        Console.WriteLine($"Estado civil: Soltero");
    }
    else
    {
        Console.WriteLine($"Estado civil: Casado");
    }
    Console.WriteLine($"Cargo: {item.CargoDelEmpleado}, Antiguedad: {item.calcularAntiguedad(item.IngresoAEmpresa)}");
    Console.WriteLine("Sueldo: $ " + item.calcularSalario());

    totalAPagar = totalAPagar + item.calcularSalario();
}
Console.WriteLine($"\nTotal en sueldos: $ {totalAPagar}\n");
