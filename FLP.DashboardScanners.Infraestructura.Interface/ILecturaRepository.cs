using FLP.DashboardScanners.Dominio.Entity;
using FLP.DashboardScanners.Domino.Entity;

namespace FLP.DashboardScanners.Infraestructura.Interface
{
    public interface ILecturaRepository
    {
        #region Métodos síncronos
        IEnumerable<LecturaResponse> GetAll();
        IEnumerable<LecturaResponse> GetAllErrors();
        IEnumerable<RatioDeErrorResponse> GetRatioError(DateTime fechaDesde, DateTime fechaHasta);
        IEnumerable<RatioDeErrorResponse> GetRatioDeErrorByDeviceName(string deviceName, DateTime fechaDesde, DateTime fechaHasta);
        Dispositivo GetDispositivo(string deviceName);
        IEnumerable<RastreoCajaResponse> GetRastreoCaja(string barcode);
        #endregion

        #region Métodos asíncronos
        Task<IEnumerable<LecturaResponse>> GetAllAsync();
        Task<IEnumerable<LecturaResponse>> GetAllErrorsAsync();
        Task<IEnumerable<RatioDeErrorResponse>> GetRatioErrorAsync(DateTime fechaDesde, DateTime fechaHasta);
        Task<IEnumerable<RatioDeErrorResponse>> GetRatioDeErrorByDeviceNameAsync(string deviceName, DateTime fechaDesde, DateTime fechaHasta);
        Task<Dispositivo> GetDispositivoAsync(string deviceName);
        Task<IEnumerable<RastreoCajaResponse>> GetRastreoCajaAsync(string barcode);
        #endregion

    }
}
