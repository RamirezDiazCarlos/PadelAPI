using Domain.Enums;

namespace Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }
        public PosicionJuego PosicionEnCancha { get; set; }
    }
}

