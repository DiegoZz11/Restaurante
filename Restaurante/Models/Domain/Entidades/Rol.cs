namespace Restaurante.Models.Domain.Entidades
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; //Admin, Mesero, Cocina
        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
