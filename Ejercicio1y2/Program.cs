using POO_Ejercicios.Ejercicio1y2;

namespace POO_Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase autobus
            Autobus autobus = new Autobus("Mercedes", "Sprinter", 2023, "Azul", 30, 2, 30);

            //Instancia inicial del Autobus (capacidad 0)
            autobus.MostrarInfo();

            Console.WriteLine();

            autobus.CargaPasajeros(10);
            autobus.CargaPasajeros(25);
            autobus.DescargaPasajeros(5);
            autobus.DescargaPasajeros(50);

            Console.WriteLine();
            //Instacia final del autobus
            autobus.MostrarInfo();

            Console.WriteLine();

            //Clase coche
            Coche coche = new Coche("Jeep", "Renegade", 2021, "Negro", true);

            coche.MostrarDatos();

            coche.TocarBocina();

            Console.WriteLine();

            //Clase Camión
            Camion camion = new Camion("Volvo", "FH16", 2022, "Blanco", 25000);

            camion.MostrarDatos();

            camion.Cargar(5000);

            Console.WriteLine();

            //Clase moto
            Moto moto = new Moto("Yamaha", "MT-03", 2021, "Rojo", false);

            moto.MostrarDatos();

            moto.HacerWheelie();
        }
    }
}