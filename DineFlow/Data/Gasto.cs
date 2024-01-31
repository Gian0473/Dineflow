namespace DineFlow.Data
{
    public class Gasto
    {
        public int id_gastos { get; set; }
        public DateTime fecha_gasto { get; set; }
        public decimal monto { get; set; }
        public string descripcion_gasto { get; set; }
        public int id_usuarios { get; set; }
    }

    public class Gasto_DD
    {
        public DateOnly fecha { get; set; }
        public int total { get; set; }
    }

    public class Gasto_MM
    {
        public int year { get; set; }
        public int month { get; set; }
        public int total { get; set; }
    }

    public class Gasto_YY
    {
        public int year { get; set; }
        public int total { get; set; }
    }
}
