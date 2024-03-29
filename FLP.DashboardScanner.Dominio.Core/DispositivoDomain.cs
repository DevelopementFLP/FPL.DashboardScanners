using FLP.DashboardScanners.Dominio.Interface;
using FLP.DashboardScanners.Domino.Entity;
using FLP.DashboardScanners.Infraestructura.Interface;

namespace FLP.DashboardScanners.Dominio.Core
{
    public class DispositivoDomain : IDispositivoDomain
    {
        private readonly ILecturaRepository _lecturaRepository;

        public DispositivoDomain(ILecturaRepository lecturaRepository) => _lecturaRepository = lecturaRepository;

        #region Métodos síncronos
        public Dispositivo GetDispositivo(string deviceName) => _lecturaRepository.GetDispositivo(deviceName);
        #endregion

        #region Métodos asíncronos
        public Task<Dispositivo> GetDispositivoAsync(string deviceName) => _lecturaRepository.GetDispositivoAsync(deviceName);
        #endregion
    }
}
