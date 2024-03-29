using FLP.DashboardScanners.Dominio.Entity;
using FLP.DashboardScanners.Dominio.Interface;
using FLP.DashboardScanners.Infraestructura.Interface;

namespace FLP.DashboardScanners.Dominio.Core
{
    public class RatioDeErrorDomain : IRatioDeErrorDomain
    {
        private readonly ILecturaRepository _lecturaRepository;

        public RatioDeErrorDomain(ILecturaRepository lecturaRepository) => _lecturaRepository = lecturaRepository;

      

        #region Métodos síncronos
        public IEnumerable<RatioDeErrorResponse> GetRatioError(DateTime fechaDesde, DateTime fechaHasta) => _lecturaRepository.GetRatioError(fechaDesde, fechaHasta);
        public IEnumerable<RatioDeErrorResponse> GetRatioDeErrorByDeviceName(string dispositivo, DateTime fechaDesde, DateTime fechaHasta) => _lecturaRepository.GetRatioDeErrorByDeviceName(dispositivo, fechaDesde, fechaHasta);
        #endregion

        #region Métodos asíncronos
        public Task<IEnumerable<RatioDeErrorResponse>> GetRatioErrorAsync(DateTime fechaDesde, DateTime fechaHasta) => _lecturaRepository.GetRatioErrorAsync(fechaDesde, fechaHasta);
        public Task<IEnumerable<RatioDeErrorResponse>> GetRatioDeErrorByDeviceNameAsync(string dispositivo, DateTime fechaDesde, DateTime fechaHasta) => _lecturaRepository.GetRatioDeErrorByDeviceNameAsync(dispositivo, fechaDesde, fechaHasta);
        #endregion
    }
}
