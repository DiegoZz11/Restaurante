using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models.Domain.Entidades
{
    public class Producto
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Precio { get; set; }

        public bool Activo { get; set; } = true;

        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
        public ICollection<DetallePedido> Detalles { get; set; } = new List<DetallePedido>();
    }
}

