using System.ComponentModel.DataAnnotations;

namespace RsystemWeb.Models
{
    public class DeterminarTipoUsuarioProcedure
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Username { get; set; }
        public string TipoUsuario { get; set; }
    }
}
