namespace DineFlow.Data
{
    public class Ingreso
    {
        public int id_ingresos { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public decimal monto { get; set; }
        public string descripcion_ingreso { get; set; }
        public int id_usuarios { get; set; }
    }

    public class Ingreso_DD
    {
        public DateOnly fecha { get; set; }
        public int total { get; set; }
    }

    public class Ingreso_MM
    {
        public int year { get; set; }
        public int month { get; set; }
        public int total { get; set; }
    }

    public class Ingreso_YY
    {
        public int year { get; set; }
        public int total { get; set; }
    }
}
