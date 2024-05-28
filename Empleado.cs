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
    private DateTime Nacimiento = new DateTime(); // revisa los date time
    public void obtenerNacimiento(DateTime valor)
    {
        
    }
    private char estadoCivil;
    public void guardarEstado(char valor)
    {
        estadoCivil = valor;
    }
    private DateTime ingresoAEmpresa = new DateTime();
    public void obtenerIngreso(DateTime valor)
    {
        ingresoAEmpresa = valor;
    }
    private double sueldoBasico;
    public void guardarSueldo(double valor)
    {
        sueldoBasico = valor;
    }
    private enum Cargo { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador, }

}