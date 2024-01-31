namespace DineFlow.Data
{
    public class Mesa
    {
        public int id_mesa {  get; set; }
        public int id_usuarios { get; set; }
        public string codigo_qr { get; set; }
        public int id_pedido { get; set; }
    }
}
