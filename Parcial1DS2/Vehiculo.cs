using System;

class Vehiculo
{
    // Propiedades
    private string Marca { get; set; }
    private string Modelo { get; set; }
    private int Año { get; set; }
    private double VelocidadActual { get; set; }

    // Constructor
    public Vehiculo(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
        VelocidadActual = 0.0; // Velocidad inicial = 0
    }

    // Metodo Acelerar
    public void Acelerar(double cantidad)
    {
        VelocidadActual += cantidad;
        Console.WriteLine($"El vehiculo ha acelerado a {VelocidadActual} km/h.");
    }

    // Metodo Frenar
    public void Frenar(double cantidad)
    {
        VelocidadActual -= cantidad;
        if (VelocidadActual < 0)
        {
            VelocidadActual = 0;
        }
        Console.WriteLine($"El vehiculo ha frenado. Velocidad actual: {VelocidadActual} km/h.");
    }

    // Metodo MostrarInformacion
    public void MostrarInformacion()
    {
        Console.WriteLine("---------- Informacion del vehiculo: ----------");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Año: {Año}");
        Console.WriteLine($"Velocidad Actual: {VelocidadActual} km/h");
    }
}
