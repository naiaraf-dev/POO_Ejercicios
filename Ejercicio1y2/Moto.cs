namespace POO_Ejercicios.Ejercicio1y2
{
    public class Moto : Vehiculo
    {
        public bool tieneBaul { get; set; }

        public Moto(string marca, string modelo, int anio, string color, bool baul)
            : base(marca, modelo, anio, color)
        {
            tieneBaul = baul;
        }

        public void HacerWheelie()
        {
            Console.WriteLine("¡La moto hace un wheelie!");
        }

        public void MostrarDatos()
        {
            MostrarInformacion();
            Console.WriteLine($"Con baúl?: {(tieneBaul ? "Sí" : "No")}");
        }
    }
}