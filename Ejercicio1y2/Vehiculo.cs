namespace POO_Ejercicios.Ejercicio1y2
{
    public class Vehiculo
    {
        public string marcaVehiculo { get; set; }
        public string modeloVehiculo { get; set; }
        public int anioVehiculo { get; set; }
        public string colorVehiculo { get; set; }

        public Vehiculo(string marca, string modelo, int anio, string color)
        {
            marcaVehiculo = marca;
            modeloVehiculo = modelo;
            anioVehiculo = anio;
            colorVehiculo = color;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {marcaVehiculo}, Modelo: {modeloVehiculo}, Año: {anioVehiculo}, Color: {colorVehiculo}");
        }
    }
}