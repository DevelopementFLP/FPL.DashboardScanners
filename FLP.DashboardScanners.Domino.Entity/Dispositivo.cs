namespace FLP.DashboardScanners.Domino.Entity
{
    public class Dispositivo
    {
        public int Id_Dispositivo { get; set; }
        public string Nombre { get; set; }
        public string IP {  get; set; }
        public int Puerto { get; set; }
        public string Descripcion { get; set; }
        public bool Activo {  get; set; }
        public int Id_Tipo{ get; set; }
        public int Id_Ubicacion { get; set; }
        public int Id_Formato {  get; set; }
    }
}
