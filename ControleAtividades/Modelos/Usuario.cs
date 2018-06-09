using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Usuario
    {   [Key]
        public int UsuarioID { get; set; }
        [Required, StringLength(30),]
        public string Nome { get; set; }

        public bool Ativo { get; set; }
    }
}
