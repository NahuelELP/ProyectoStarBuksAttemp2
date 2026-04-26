namespace WebApp.Model
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty; //Evita null reference

        public string Email { get; set; } = string.Empty;
    }
}
