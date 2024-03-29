namespace FLP.DashboardScanners.Aplicacion.DTO
{
    public class RatioDeErrorResponseDto
    {
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public string Dispositivo { get; set; }
        public int Ok { get; set; }
        public int NoRead { get; set; }
    }
}
