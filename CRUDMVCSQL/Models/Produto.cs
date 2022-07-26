using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDMVCSQL.Models
{
    /// <summary>
    /// Classe criada para adicionar tabela "Produto" e colunas "ID" e "Nome".
    /// </summary>
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

    }
}
