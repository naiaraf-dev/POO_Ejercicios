namespace POO_Ejercicios.Ejercicio3
{
    public class Animal
    {
        //Atributos
        public string nombreAnimal { get; set; }
        public string especie { get; set; }
        public int edad { get; set; }
        public string genero { get; set; }
        public string sonidoAnimal { get; set; }

        // Constructor
        public Animal(string nombreAnimal, string especie, int edad, string genero, string sonidoAnimal)
        {
            this.nombreAnimal = nombreAnimal;
            this.especie = especie;
            this.edad = edad;
            this.genero = genero;
            this.sonidoAnimal = sonidoAnimal;
        }

        //Métodos
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombreAnimal}, Especie: {especie}, Edad: {edad}, Género: {genero}, Sonido: {sonidoAnimal}");
        }

        public void Alimentar(string nomAnimal)
        {
            Console.WriteLine($"{nomAnimal} está comiendo.");
        }

        public void HacerSonido(string nomAnimal, string sonido)
        {
            Console.WriteLine($"{nomAnimal} hace {sonido}");
        }
    }
}