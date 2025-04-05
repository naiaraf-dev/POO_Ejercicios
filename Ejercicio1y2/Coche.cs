namespace POO_Ejercicios.Ejercicio1y2
{
    public class Coche : Vehiculo
    {
        public bool tieneAireAcondicionado { get; set; }

        public Coche(string marca, string modelo, int anio, string color, bool aireAcondicionado)
            : base(marca, modelo, anio, color)
        {
            tieneAireAcondicionado = aireAcondicionado;
        }

        public void TocarBocina()
        {
            Console.WriteLine("¡Pii pii!");
        }

        public void MostrarDatos()
        {
            MostrarInformacion();
            Console.WriteLine($"Aire acondicionado: {(tieneAireAcondicionado ? "Sí" : "No")}");
        }
    }
}