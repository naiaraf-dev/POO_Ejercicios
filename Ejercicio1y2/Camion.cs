namespace POO_Ejercicios.Ejercicio1y2
{
    public class Camion : Vehiculo
    {
        public double capacidadCargaKg { get; set; }

        public Camion(string marca, string modelo, int anio, string color, double capacidadCarga)
            : base(marca, modelo, anio, color)
        {
            capacidadCargaKg = capacidadCarga;
        }

        public void Cargar(double carga)
        {
            Console.WriteLine($"Cargando {carga} kg en el camión.");
        }

        public void MostrarDatos()
        {
            MostrarInformacion();
            Console.WriteLine($"Capacidad de carga: {capacidadCargaKg} kg");
        }
    }
}