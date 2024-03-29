using FLP.DashboardScanners.Dominio.Entity;

namespace FLP.DashboardScanners.Dominio.Interface
{
    public interface IRastreoCajaDomain
    {
        #region Métodos síncronos
        IEnumerable<RastreoCajaResponse> GetRastreoCaja(string barcode);
        #endregion

        #region Métodos asíncronos
        Task<IEnumerable<RastreoCajaResponse>> GetRastreoCajaAsync(string barcode);
        #endregion
    }
}
