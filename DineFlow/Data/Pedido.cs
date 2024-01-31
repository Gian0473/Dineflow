namespace DineFlow.Data
{
    public class Pedido
    {
        public CabeceraPedido cabecera {  get; set; }
        public List<DetallePedido> detalle { get; set; }
    }

    public class CabeceraPedido
    {
        public int id_pedido { get; set; }
        public DateTime fecha { get; set; }
        public int id_mesa {  get; set; }
        public int id_usuarios { get; set; }
        public int id_ingresos { get; set; }
        public string pedido_numero { get; set; }
    }

    public class DetallePedido
    {
        public int id_detalle { get; set; }
        public int id_pedido { get; set; }
        public int id_platillo { get; set; }
        public string nombre_platillo { get; set; }
        public int cantidad { get; set; }
        public int costo { get; set; }
    }
}
