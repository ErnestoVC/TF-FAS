namespace Event.Domain
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string usuario { get; set; }
        public string contrasenia { get; set; }

        public CatUsuario CatUsuario { get; set; }
        public int IdCatUsuario { get; set; }
    }
}