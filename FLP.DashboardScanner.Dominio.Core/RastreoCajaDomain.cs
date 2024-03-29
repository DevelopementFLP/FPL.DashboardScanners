using FLP.DashboardScanners.Dominio.Entity;
using FLP.DashboardScanners.Dominio.Interface;
using FLP.DashboardScanners.Infraestructura.Interface;

namespace FLP.DashboardScanners.Dominio.Core
{
    public class RastreoCajaDomain : IRastreoCajaDomain
    {
        private readonly ILecturaRepository _lecturaRepository;

        public RastreoCajaDomain(ILecturaRepository lecturaRepository) => _lecturaRepository = lecturaRepository;


        #region Métodos síncronos
        public IEnumerable<RastreoCajaResponse> GetRastreoCaja(string barcode) => _lecturaRepository.GetRastreoCaja(barcode);
        #endregion

        #region Métodos asíncronos
        public Task<IEnumerable<RastreoCajaResponse>> GetRastreoCajaAsync(string barcode) => _lecturaRepository.GetRastreoCajaAsync(barcode);
        #endregion
    }
}
