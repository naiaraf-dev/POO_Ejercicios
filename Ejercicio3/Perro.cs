namespace POO_Ejercicios.Ejercicio3
{
    public class Perro : Animal
    {
        //Atributos
        public string color { get; set; }
        public bool manchas { get; set; }

        //Métodos
        public Perro(string nombreAnimal, string especie, int edad, string genero, string sonidoAnimal, string colorPerro, bool manchasPerro)
            : base(nombreAnimal, especie, edad, genero, sonidoAnimal)
        {
            color = colorPerro;
            manchas = manchasPerro;
        }

        public void MostrarInfo()
        {
            MostrarInformacion();
            Console.WriteLine($"Color: {color}\n");
            Console.WriteLine($"Tiene manchas?: {(manchas ? "Sí" : "No")}\n");
        }
    }
}