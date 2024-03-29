using FLP.DashboardScanners.Domino.Entity;

namespace FLP.DashboardScanners.Interface
{
    public interface ILecturaResponseDomain
    {
        #region Métodos síncronos
        IEnumerable<LecturaResponse> GetAll();
        IEnumerable<LecturaResponse> GetAllErrors();
        #endregion

        #region Métodos asíncronos
        Task<IEnumerable<LecturaResponse>> GetAllAsync();
        Task<IEnumerable<LecturaResponse>> GetAllErrorsAsync();
        #endregion
    }
}
