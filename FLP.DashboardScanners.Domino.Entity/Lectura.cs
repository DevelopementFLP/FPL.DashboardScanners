namespace FLP.DashboardScanners.Domino.Entity
{
    public class Lectura
    {
        public int IdLectura { get; set; }
        public int IdDispositivo { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
