namespace Restaurante.Models.Domain.Entidades
{
    public class Mesa
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int Capacidad { get; set; }
        public string Disponible { get; set; } = "Disponible"; // "Disponible","Ocupada", "Reservada"

        public ICollection<Reservacion> Reservaciones { get; set; } = new List<Reservacion>();
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
