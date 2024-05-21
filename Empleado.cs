namespace EspacioEmpleado;

public class Empleado
{
    private string nombre;
    private string apellido;
    private string Nacimiento = new DateTime();
    private char EstadoCivil;
    private string ingreso = new DateTime();
    private double SueldoBasico;
    private enum Cargo { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador, }


}