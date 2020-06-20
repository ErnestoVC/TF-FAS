namespace Event.Domain
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string DNI { get; set; }

        public Usuario usuario { get; set; }
        public int IdUsuario { get; set; }
    }
}