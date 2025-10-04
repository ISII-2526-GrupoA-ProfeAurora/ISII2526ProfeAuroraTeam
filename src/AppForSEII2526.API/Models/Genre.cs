namespace AppForSEII2526.API.Models
{
    public class Genre
    {
        public Genre()
        {
        } // Constructor por defecto requerido por EF Core

        public Genre(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Title name cannot be longer than 50 characters.", MinimumLength = 4)]
        public string Name { get; set; }

        public List<Movie> Movies { get; set; } = new(); // Inicialización segura
    }

}
