using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models.Domain.Entidades
{
    public class SolicitudCambio
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuarios? Usuario { get; set; }
        public int ProductoId { get; set; }
        public Producto? Producto { get; set; }

        [Required] public string TipoCambio { get; set; } = "Precio"; //Precio|Estado
        [Required] public string ValorNuevo { get; set; } = string.Empty;

    }
}
