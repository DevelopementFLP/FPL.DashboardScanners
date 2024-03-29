using FLP.DashboardScanners.Aplicacion.DTO;
using FPL.DashboardScanners.Transversal.Common;

namespace FLP.DashboardScanners.Aplicacion.Interface
{
    public interface IRastreoCajaResponseAplicacion
    {
        #region Métodos síncronos
        Response<IEnumerable<RastreoCajaResponseDto>> GetRastreoCaja(string barcode);
        #endregion

        #region Métodos asíncronos
        Task<Response<IEnumerable<RastreoCajaResponseDto>>> GetRastreoCajaAsync(string barcode);
        #endregion
    }
}
