using System.Data;

namespace FPL.DashboardScanners.Transversal.Common
{
    public interface IConnectionFactory
    {
        public IDbConnection? GetConnection { get; }
    }
}
