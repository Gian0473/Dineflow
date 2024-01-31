namespace DineFlow.Data
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string contraseña { get; set; }
    }

    public class Cuenta
    {
        public int id_usuarios { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public string email { get; set; }
        public string nombre_negocio { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
    }
}
