
namespace EspacioEmpleado;

public partial class Empleado
{
    private string nombre;
    private string apellido;
    private DateOnly nacimiento;
    private char estadoCivil;
    private DateOnly ingresoAEmpresa;
    private double sueldoBasico = 150000;
    private double salario;
    private cargo cargoDelEmpleado;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateOnly Nacimiento { get => nacimiento; set => nacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateOnly IngresoAEmpresa { get => ingresoAEmpresa; set => ingresoAEmpresa = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public cargo CargoDelEmpleado { get => cargoDelEmpleado; set => cargoDelEmpleado = value; }
    public double Salario { get => salario; set => salario = value; }

    public enum cargo { 
        Auxiliar, 
        Administrativo, 
        Ingeniero, 
        Especialista,
        Investigador, }

    public int calcularAntiguedad(DateOnly ingre)
    {
        int antiguedad;
        DateTime hoy = DateTime.Now;

        antiguedad = hoy.Year - ingre.Year;

        return antiguedad;
    }

    public double calcularSalario()
    {
        int antiguedad = calcularAntiguedad(ingresoAEmpresa);
        double adicional;
        double total;

        if (antiguedad >= 20)
        {
            adicional = 0.25;
        }
        else
        {
            adicional = antiguedad * 0.1;
        }

        if (CargoDelEmpleado == (cargo)2 || cargoDelEmpleado == (cargo)3)
        {
            adicional = adicional + 0.5;
        }

        if (estadoCivil == 'C')
        {
            total = sueldoBasico + (sueldoBasico * adicional) + 150000;
        }
        else
        {
            total = sueldoBasico + (sueldoBasico * adicional);
        }

        return total;
    }

}