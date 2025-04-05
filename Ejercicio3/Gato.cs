namespace POO_Ejercicios.Ejercicio3
{
    public class Gato : Animal
    {
        //Atributos
        public string color {  get; set; }
        public bool muchoPelo { get; set; }

        //Métodos
        public Gato(string nombreAnimal, string especie, int edad, string genero, string sonidoAnimal, string colorGato, bool muchoPeloGato)
            : base(nombreAnimal, especie, edad, genero, sonidoAnimal)
        {
            color = colorGato;
            muchoPelo = muchoPeloGato;
        }

        public void MostrarDatos()
        {
            MostrarInformacion();
            Console.WriteLine($"Color: {color}\n");
            Console.WriteLine($"Tiene mucho pelo?: {(muchoPelo ? "Sí" : "No")}\n");
        }
    }
}