namespace POO_Ejercicios.Ejercicio1y2
{
    class Autobus : Vehiculo
    {
        //Atributos
        public int capacidadPasajeros { get; set; }
        public int numPuertas { get; set; }
        public int numAsientos { get; set; }
        public int pasajerosActuales { get; private set; }

        //Métodos
        public Autobus(string marca, string modelo, int anio, string color, int capacidad, int puertas, int asientos)
           : base(marca, modelo, anio, color)
        {
            capacidadPasajeros = capacidad;
            numPuertas = puertas;
            numAsientos = asientos;
            pasajerosActuales = 0;
        }

        public void CargaPasajeros(int cantidad)
        {
            if (pasajerosActuales + cantidad <= capacidadPasajeros)
            {
                pasajerosActuales += cantidad;
                Console.WriteLine($"{cantidad} pasajeros subieron al autobús.");
            } else
            {
                Console.WriteLine("Se ha llegado al límite de pasajeros.");
            }
        }

        public void DescargaPasajeros(int cantidad)
        {
            if (cantidad <= pasajerosActuales)
            {
                pasajerosActuales -= cantidad;
                Console.WriteLine($"{cantidad} pasajeros bajaron del autobús.");
            } else
            {
                Console.WriteLine("No hay esa cantidad de pasajeros arriba del autobús para bajar.");
            }
        }

        public void MostrarInfo()
        {
            MostrarInformacion();
            Console.WriteLine($"Capacidad: {capacidadPasajeros}, Puertas: {numPuertas}, Asientos: {numAsientos}, Pasajeros: {pasajerosActuales}");
        }
    }
}