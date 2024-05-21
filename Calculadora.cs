// será por la version, ahora el namespace no lleva llaves
// el namespace sirve para relaciones funciones de distintos archivos
// cuando llames Espaciocalculadora, va a llamar TODOS los EspacioCalculadora que existan
namespace EspacioCalculadora;
public class Calculadora  // a veces se lo llama atributo
{
    private double dato;  // campo
    // no hace falta inicializar en 0 porque C# inicializa así por defecto
    // por este caso no vas a crear un constructor, se crea implicitamente

    public global::System.Double Resultado { get => dato; } // esta es una propiedad
    // get devuelve el valor de dato
    // set le asigna un valor a dato
    // acá tenes algo importante: Resultado NO es una variable, es una PROPIEDAD



    public void Sumar(double termino)
    {
        dato += termino;
    }
    public void Restar(double termino)
    {
        dato -= termino;
    }
    public void Multiplicar(double termino)
    {
        dato *= termino;
    }
    public void Dividir(double termino)
    {
        dato /= termino;
    }
    public void Limpiar()
    {
        dato = 0;
    }
}