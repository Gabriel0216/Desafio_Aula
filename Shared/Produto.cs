using System;
using System.ComponentModel.DataAnnotations;

namespace Desafio_Aula.Shared
{
    public class Produto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        [Range(0, 99999.99)]
        public Decimal Preco { get; set; }
    }
}