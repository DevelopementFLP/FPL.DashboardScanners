using FLP.DashboardScanners.Aplicacion.DTO;
using FPL.DashboardScanners.Transversal.Common;

namespace FLP.DashboardScanners.Aplicacion.Interface
{
    public interface ILecturaResponseAplicacion
    {
        #region Métodos síncronos
        Response<IEnumerable<LecturaResponseDto>> GetAll();
        Response<IEnumerable<LecturaResponseDto>> GetAllErrors();
        #endregion

        #region Métodos asíncronos
        Task<Response<IEnumerable<LecturaResponseDto>>> GetAllAsync();
        Task<Response<IEnumerable<LecturaResponseDto>>> GetAllErrorsAsync();
        #endregion
    }
}
