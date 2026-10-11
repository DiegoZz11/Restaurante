using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models.Domain.Entidades
{
    public class Reservacion
    {
        public int Id { get; set; }
        public int MesaId { get; set; }
        public Mesa? Mesa { get; set; }
        [Required, StringLength(100)] public string NombreCliente { get; set; } = string.Empty;
        public string? TelefonoCliente { get; set; }
        [Required] public DateTime FechaHora { get; set; }

        [Range(1,50)] public int NumeroPersonas { get; set; }
        public string Estado { get; set; } = "Pendiente"; // Pendiente, Confirmada, Cancelada

    }
}
