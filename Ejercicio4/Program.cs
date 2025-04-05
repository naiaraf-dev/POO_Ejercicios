namespace POO_Ejercicios.Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro(
                titulo: "Cien años de soledad",
                autor: "Gabriel García Márquez",
                anioPublicacion: 1967,
                genero: "Realismo mágico"
            );

            libro1.Abrir();
            libro1.Leer();
            libro1.Cerrar();

            Console.WriteLine();

            Libro libro2 = new Libro(
                titulo: "1984",
                autor: "George Orwell",
                anioPublicacion: 1949,
                genero: "Distopía"
            );

            libro2.Abrir();
            libro2.Leer();
            libro2.Cerrar();
        }
    }
}
