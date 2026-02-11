using BLIBLIOTECA.Comunication.Resquest;
using BLIBLIOTECA.Models;

namespace BLIBLIOTECA.Services { 
    public class BookService : IBookService
        {
            private static List<Livro> _livros = new List<Livro>();

            public List<Livro> GetAll() => _livros;

            public Livro GetById(int id) => _livros.FirstOrDefault(l => l.Id == id);

           
            public bool Exists(string title, string author)
            {
                return _livros.Any(l =>
                    l.Title.Equals(title, StringComparison.OrdinalIgnoreCase) &&
                    l.Author.Equals(author, StringComparison.OrdinalIgnoreCase));
            }

          
            public void Add(Livro livro)
            {
                
                livro.Id = _livros.Count > 0 ? _livros.Max(l => l.Id) + 1 : 1;
                _livros.Add(livro);
            }

            public bool Delete(int id)
            {
                var livro = GetById(id);
                if (livro == null) return false;

                _livros.Remove(livro);
                return true;
            }

            public bool Update(int id, Requestcreatbook request)
            {
                var livroExistente = GetById(id);
                if (livroExistente == null) return false;

                livroExistente.Title = request.Title;
                livroExistente.Author = request.Author;
                livroExistente.Year = request.Year;
                livroExistente.Genre = request.Genre;
                livroExistente.Description = request.Description;
                livroExistente.Price = request.Price;
                livroExistente.Stock = request.Stock;

                return true;
            }
        }
    }
