using FLP.DashboardScanners.Domino.Entity;

namespace FLP.DashboardScanners.Dominio.Interface
{
    public interface IDispositivoDomain
    {
        #region Métodos síncronos
        Dispositivo GetDispositivo(string deviceName);
        #endregion

        #region Métodos asíncronos
        Task<Dispositivo> GetDispositivoAsync(string deviceName);
        #endregion
    }
}
