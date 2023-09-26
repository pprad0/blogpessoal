using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogpessoal.Model
{
    public class Tema
    {
        [Key] //PK (ID)
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // IDENTITY (1,1)
        public long Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(1000)]
        public string Descricao { get; set; } = string.Empty;

    }
}
