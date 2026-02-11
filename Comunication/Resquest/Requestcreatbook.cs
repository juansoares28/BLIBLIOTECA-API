using BLIBLIOTECA.Comunication.Resquest;
using BLIBLIOTECA.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using static BLIBLIOTECA.Models.Genre;

namespace BLIBLIOTECA.Comunication.Resquest
{
    public class Requestcreatbook
    {
        [Required(ErrorMessage = "O título é obrigatório")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "O autor é obrigatório")]
        public required string Author { get; set; }

        [Required(ErrorMessage = "O ano de publicação é obrigatório")]
        [Range(1000, 2100, ErrorMessage = "O ano deve ser válido (entre 1000 e 2100)")]
        public required int Year { get; set; }

        [Required(ErrorMessage = "O gênero do livro é obrigatório")]
        [EnumDataType(typeof(Genero), ErrorMessage = "Gênero inválido. Escolha uma das opções: Romance, Ficcao, Fantasia, Biografia, Historia, Ciencia ou Outro")]
        public required Genero Genre { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        public required string Description { get; set; }

        [Required(ErrorMessage = "O Preço é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public required decimal Price { get; set; }

        [Required(ErrorMessage = "O estoque é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "O estoque não pode ser negativo.")]
        public required int Stock { get; set; }
    }
}
