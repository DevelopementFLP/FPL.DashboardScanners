namespace FLP.DashboardScanners.Dominio.Entity
{
    public class RatioDeErrorResponse
    {
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public string Dispositivo { get; set; }
        public string IP { get; set; }
        public int Puerto { get; set; }
        public int Ok { get; set; }
        public int NoRead { get; set; }
    }
}
