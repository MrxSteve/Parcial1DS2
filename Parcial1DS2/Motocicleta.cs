using System;

class Motocicleta: Vehiculo
{
    // Propiedad adicional
    public int Cilindraje { get; set; }

    // Constructor
    public Motocicleta(string marca, string modelo, int año, int cilindraje)
        : base(marca, modelo, año) // Llama al constructor de la clase base
    {
        Cilindraje = cilindraje;
    }

    // Sobrescribir el metodo MostrarInformacion para incluir el cilindraje
    public void MostrarInformacion()
    {
        base.MostrarInformacion(); // Llama al metodo MostrarInformacion de la clase base
        Console.WriteLine($"Cilindraje: {Cilindraje} cc");
    }
}
