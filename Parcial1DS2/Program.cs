using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("------------ Ejercicio de la parte 1 ------------");

        // Crear un objeto de tipo Vehiculo
        Vehiculo miVehiculo = new Vehiculo("Honda", "Civic", 2019);

        // Mostrar la informacion del vehiculo
        miVehiculo.MostrarInformacion();

        // Acelerar el vehiculo
        miVehiculo.Acelerar(50);

        // Frenar el vehiculo
        miVehiculo.Frenar(20);

        // Mostrar la informacion del vehiculo despues de acelerar y frenar
        miVehiculo.MostrarInformacion();

        // Frenar mas de lo que la velocidad actual permite
        // Como la velocidad no puede ser negativa, la velocidad actual se establece en 0
        miVehiculo.Frenar(40); 

        // Mostrar la informacion final
        miVehiculo.MostrarInformacion();


        Console.WriteLine("------------ Ejercicio de la parte 2 ------------");

        // Crear un objeto de tipo Motocicleta
        Motocicleta miMotocicleta = new Motocicleta("Harley-Davidson", "Iron 883", 2023, 883);

        // Mostrar la información de la motocicleta
        miMotocicleta.MostrarInformacion();

        // Acelerar la motocicleta
        miMotocicleta.Acelerar(60);

        // Frenar la motocicleta
        miMotocicleta.Frenar(30);

        // Mostrar la informacion despues de acelerar y frenar
        miMotocicleta.MostrarInformacion();

        // Frenar mas de lo que la velocidad actual permite
        // Como la velocidad no puede ser negativa, la velocidad actual se establece en 0
        miMotocicleta.Frenar(100);

        // Mostrar la informacion final
        miMotocicleta.MostrarInformacion();
    }
}