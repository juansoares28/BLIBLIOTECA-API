using BLIBLIOTECA.Comunication.Resquest;
using BLIBLIOTECA.Models;

namespace BLIBLIOTECA.Services
{
    public interface IBookService
    {
        List<Livro> GetAll();
        Livro GetById(int id);
        void Add(Livro livro);
        bool Update(int id, Requestcreatbook request);
        bool Delete(int id);
        bool Exists(string title, string author);
    }
}
