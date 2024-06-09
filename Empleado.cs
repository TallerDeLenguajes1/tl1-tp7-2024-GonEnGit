namespace EspacioEmpleado;

public partial class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime nacimiento; // revisa los date time
    private char estadoCivil;
    private DateTime ingresoAEmpresa;
    private double sueldoBasico;
    private cargo cargoDelEmpleado;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime IngresoAEmpresa { get => ingresoAEmpresa; set => ingresoAEmpresa = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public cargo CargoDelEmpleado { get => cargoDelEmpleado; set => cargoDelEmpleado = value; }

    public enum cargo { 
        Auxiliar, 
        Administrativo, 
        Ingeniero, 
        Especialista, 
        Investigador, }

}