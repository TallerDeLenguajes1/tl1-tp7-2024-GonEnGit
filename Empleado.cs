namespace EspacioEmpleado;

public class Empleado
{
    private string nombre;
    public void guardarNombre(string valor)
    {
        nombre = valor;
    }
    private string apellido;
    public void guardarApellido(string valor)
    {
        apellido = valor;
    }
    private string Nacimiento = new DateTime(); // revisa los date time
    private char estadoCivil;
    public void guardarEstado(char valor)
    {
        estadoCivil = valor;
    }
    private string ingresoAEmpresa = new DateTime();
    private double sueldoBasico;
    public void guardarSueldo(double valor)
    {
        sueldoBasico = valor;
    }
    private enum Cargo { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador, }


}