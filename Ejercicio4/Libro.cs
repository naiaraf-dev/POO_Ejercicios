namespace POO_Ejercicios.Ejercicio4
{
    public class Libro
    {
        //Atributos
        public string titulo { get; set; }
        public string autor { get; set; }
        public int anioPublicacion { get; set; }
        public string genero { get; set; }

        //Constructor
        public Libro(string titulo, string autor, int anioPublicacion, string genero)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anioPublicacion = anioPublicacion;
            this.genero = genero;
        }

        //M�todos
        public void Abrir()
        {
            Console.WriteLine($"El libro \"{titulo}\" ha sido abierto.");
        }

        public void Cerrar()
        {
            Console.WriteLine($"El libro \"{titulo}\" ha sido cerrado.");
        }

        public void Leer()
        {
            Console.WriteLine($"Est�s leyendo \"{titulo}\" de {autor}.");
        }
    }
}