using Microsoft.VisualBasic;
using System.Reflection;
using static BLIBLIOTECA.Models.Genre;

namespace BLIBLIOTECA.Models
{
        public class Livro
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public Genero Genre { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Livro(int Id, string Title, string Author, int Year, Genero Genre, string Description, decimal Price, int Stock)
        {
            this.Id = Id;
            this.Title = Title;
            this.Author = Author;
            this.Year = Year;
            this.Genre = Genre;
            this.Description = Description;
            this.Price = Price;
            this.Stock = Stock;
        }
    }
}
