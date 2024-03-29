using FLP.DashboardScanners.Dominio.Entity;

namespace FLP.DashboardScanners.Dominio.Interface
{
    public interface IRatioDeErrorDomain
    {
        #region Métodos síncronos
        IEnumerable<RatioDeErrorResponse> GetRatioError(DateTime fechaDesde, DateTime fechaHasta);
        IEnumerable<RatioDeErrorResponse> GetRatioDeErrorByDeviceName(string dispositivo, DateTime fechaDesde, DateTime fechaHasta);
        #endregion

        #region Métodos asíncronos
        Task<IEnumerable<RatioDeErrorResponse>> GetRatioErrorAsync(DateTime fechaDesde, DateTime fechaHasta);
        Task<IEnumerable<RatioDeErrorResponse>> GetRatioDeErrorByDeviceNameAsync(string dispositivo, DateTime fechaDesde, DateTime fechaHasta);
        #endregion
    }
}
