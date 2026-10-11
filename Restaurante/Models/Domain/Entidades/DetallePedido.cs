using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models.Domain.Entidades
{
    public class DetallePedido
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Pedido? Pedido { get; set; }
        public int ProductoId { get; set; }
        public Producto? Producto { get; set; }

        [Range(1,100)] public int Cantidad { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0")]
        public decimal Precio { get; set; }

    }
}
