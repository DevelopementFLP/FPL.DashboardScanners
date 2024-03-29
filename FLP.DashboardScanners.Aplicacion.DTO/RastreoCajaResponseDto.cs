namespace FLP.DashboardScanners.Aplicacion.DTO
{
    public class RastreoCajaResponseDto
    {
        public string Dispositivo { get; set; }
        public string Ip { get; set; }
        public int Puerto { get; set; }
        public string Ubicacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Codigo { get; set; }
    }
}
