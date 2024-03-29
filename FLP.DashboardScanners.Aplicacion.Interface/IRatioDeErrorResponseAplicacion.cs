using FLP.DashboardScanners.Aplicacion.DTO;
using FPL.DashboardScanners.Transversal.Common;

namespace FLP.DashboardScanners.Aplicacion.Interface
{
    public interface IRatioDeErrorResponseAplicacion
    {
        #region Métodos síncronos
        Response<IEnumerable<RatioDeErrorResponseDto>> GetRatioError(DateTime fechaDesde, DateTime fechaHasta);
        Response<IEnumerable<RatioDeErrorResponseDto>> GetRatioDeErrorByDeviceName(string deviceName, DateTime fechaDesde, DateTime fechaHasta);
        #endregion

        #region Métodos asíncronos
        Task<Response<IEnumerable<RatioDeErrorResponseDto>>> GetRatioErrorAsync(DateTime fechaDesde, DateTime fechaHasta);
        Task<Response<IEnumerable<RatioDeErrorResponseDto>>> GetRatioDeErrorByDeviceNameAsync(string deviceName, DateTime fechaDesde, DateTime fechaHasta);
        #endregion
    }
}
