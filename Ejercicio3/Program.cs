using POO_Ejercicios.Ejercicio3;

namespace POO_Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase perro
            Perro perro = new Perro(
                nombreAnimal: "Bolt",
                especie: "Pastor blanco suizo",
                edad: 5,
                genero: "Macho",
                sonidoAnimal: "Guau",
                colorPerro: "Blanco",
                manchasPerro: false
            );

            perro.MostrarInfo();
            perro.Alimentar(perro.nombreAnimal);
            perro.HacerSonido(perro.nombreAnimal, perro.sonidoAnimal);

            Console.WriteLine();

            //Clase gato
            Gato gato = new Gato(
                nombreAnimal: "Cleopatra",
                especie: "Persa",
                edad: 3,
                genero: "Hembra",
                sonidoAnimal: "Miau",
                colorGato: "Rubio",
                muchoPeloGato: true
            );

            gato.MostrarDatos();
            gato.Alimentar(gato.nombreAnimal);
            gato.HacerSonido(gato.nombreAnimal, gato.sonidoAnimal);
        }
    }
}
