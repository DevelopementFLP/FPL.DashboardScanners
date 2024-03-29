namespace FLP.DashboardScanners.Aplicacion.DTO
{
    public class LecturaResponseDto
    {
        public DateTime Fecha { get; set; }
        public string Dispositivo { get; set; }
        public string Ubicacion { get; set; }
        public int CantidadLecturas { get; set; }
    }
}
