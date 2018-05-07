using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLivrariaEstoque.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public int Quantidade { get; set; }
        public string Observacoes { get; set; }
    }
}