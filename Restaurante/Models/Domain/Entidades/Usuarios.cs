using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models.Domain.Entidades
{
    public class Usuarios
    {
        public int Id { get; set; }
        [Required, StringLength(100)] public string Nombre { get; set; } = string.Empty;
        [Required, EmailAddress] public string Email { get; set; } = string.Empty;
        [Required] public string Password { get; set; } = string.Empty;

        public int RolId { get; set; }
        public Rol? Rol { get; set; }

        public ICollection<Pedido> pedidos { get; set; } = new List<Pedido>();
        public ICollection<SolicitudCambios> Solicitudes { get; set; } = new List<SolicitudCambios>();

    }
}
