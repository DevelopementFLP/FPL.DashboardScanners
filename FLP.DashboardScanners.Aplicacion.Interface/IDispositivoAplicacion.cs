using FLP.DashboardScanners.Aplicacion.DTO;
using FPL.DashboardScanners.Transversal.Common;

namespace FLP.DashboardScanners.Aplicacion.Interface
{
    public interface IDispositivoAplicacion
    {
        #region Métodos síncronos
        Response<DispositivoResponseDto> GetDispositivo(string deviceName);
        #endregion

        #region Métodos asíncronos
        Task<Response<DispositivoResponseDto>> GetDispositivoAsync(string deviceName);
        #endregion
    }
}
