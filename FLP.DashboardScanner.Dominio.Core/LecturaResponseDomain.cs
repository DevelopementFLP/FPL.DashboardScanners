using FLP.DashboardScanners.Domino.Entity;
using FLP.DashboardScanners.Infraestructura.Interface;
using FLP.DashboardScanners.Interface;

namespace FLP.DashboardScanners.Dominio.Core
{
    public class LecturaResponseDomain : ILecturaResponseDomain
    {
        private readonly ILecturaRepository _lecturaRepository;

        public LecturaResponseDomain(ILecturaRepository lecturaRepository) => _lecturaRepository = lecturaRepository;

        #region Métodos síncronos
        public IEnumerable<LecturaResponse> GetAll() => _lecturaRepository.GetAll();
        public IEnumerable<LecturaResponse> GetAllErrors() => _lecturaRepository.GetAllErrors();
        #endregion

        #region Métodos asíncronos
        public async Task<IEnumerable<LecturaResponse>> GetAllAsync() => await _lecturaRepository.GetAllAsync();
        public async Task<IEnumerable<LecturaResponse>> GetAllErrorsAsync() => await _lecturaRepository.GetAllErrorsAsync();
        #endregion
    }
}
