using System.Drawing;

namespace Restaurante.Models.Domain.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public int MesaId { get; set; }
        public Mesa? Mesa { get; set; }
        public int UsuarioId { get; set; } //mesero que atiende el pedido
        public Usuario? Usuario { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;
        public String Estado { get; set; } = "Pendiente"; // Pendiente, En Proceso, Listo, Entregado

        public ICollection<DetallePedido> Detalles { get; set; } = new List<DetallePedido>();

    }
}
