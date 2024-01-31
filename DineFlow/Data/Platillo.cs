namespace DineFlow.Data
{
    public class Platillo
    {
        public int id_platillo { get; set; }
        public string nombre_platillo { get; set; }
        public int costo { get; set; }
        public string descripcion_platillo { get; set; }
        public string imagen { get; set; }
        public int id_usuarios { get; set; }
        public int cant {  get; set; }
    }
}
