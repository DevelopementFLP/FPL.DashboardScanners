using Dapper;
using FLP.DashboardScanners.Dominio.Entity;
using FLP.DashboardScanners.Domino.Entity;
using FLP.DashboardScanners.Infraestructura.Interface;
using FPL.DashboardScanners.Transversal.Common;
using System.Data;
using System.Data.SqlClient;

namespace FLP.DashboardScanners.Infraestructura.Repository
{
    public class LecturaRepository : ILecturaRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public LecturaRepository(IConnectionFactory connectionFactory) => _connectionFactory = connectionFactory;

        #region Métodos síncronos
        public IEnumerable<LecturaResponse> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "BCPFLP_ResumenLecturasXUbicacion";
                var lectures = connection.Query<LecturaResponse>(query, commandType: CommandType.StoredProcedure);
                return lectures;
            }
        }

        public IEnumerable<LecturaResponse> GetAllErrors()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "BCPFLP_ResumenLecturasConError";
                var lectures = connection.Query<LecturaResponse>(query, commandType: CommandType.StoredProcedure);
                return lectures;
            }
        }

        public IEnumerable<RatioDeErrorResponse> GetRatioError(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "BCPFLP_RatioDeError";
                // Crear el parámetro para fechaDesde
                var paramDesde = new SqlParameter("@desde", SqlDbType.DateTime);
                paramDesde.Value = fechaDesde;

                // Crear el parámetro para fechaHasta
                var paramHasta = new SqlParameter("@hasta", SqlDbType.DateTime);
                paramHasta.Value = fechaHasta;

                // Ejecutar la consulta utilizando Dapper y pasar los parámetros
                var lectures = connection.Query<RatioDeErrorResponse>(query, new { desde = fechaDesde, hasta = fechaHasta }, commandType: CommandType.StoredProcedure);
                return lectures;
            }
        }

        public IEnumerable<RatioDeErrorResponse> GetRatioDeErrorByDeviceName(string deviceName, DateTime fechaDesde, DateTime fechaHasta) 
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "BCPFLP_RatioDeErrorPorUbicacion";

                var paramDeviceName = new SqlParameter("@dispositivo", SqlDbType.NVarChar);
                paramDeviceName.Value = deviceName;

                // Crear el parámetro para fechaDesde
                var paramDesde = new SqlParameter("@desde", SqlDbType.DateTime);
                paramDesde.Value = fechaDesde;

                // Crear el parámetro para fechaHasta
                var paramHasta = new SqlParameter("@hasta", SqlDbType.DateTime);
                paramHasta.Value = fechaHasta;

                // Ejecutar la consulta utilizando Dapper y pasar los parámetros
                var lectures = connection.Query<RatioDeErrorResponse>(query, new { dispositivo = deviceName, desde = fechaDesde, hasta = fechaHasta }, commandType: CommandType.StoredProcedure);
                return lectures;
            }
        }

        public Dispositivo GetDispositivo(string deviceName)
        {
            using (var connection = _connectionFactory.GetConnection) {
                var query = "select * from Dispositivos where nombre = @nombre";

                var paramDeviceName = new SqlParameter("@nombre", SqlDbType.NVarChar);
                paramDeviceName.Value = deviceName;

                var device = connection.QuerySingle<Dispositivo>(query, new { nombre = deviceName });
                return device;
            }

        }

        public IEnumerable<RastreoCajaResponse> GetRastreoCaja(string barcode)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "BCPFLP_RastreoCaja";

                var paramBarcode = new SqlParameter("@codigoBarra", SqlDbType.NVarChar);
                paramBarcode.Value = barcode;

                var rastreo = connection.Query<RastreoCajaResponse>(query, new { codigoBarra = barcode}, commandType: CommandType.StoredProcedure);
                return rastreo;
            }
        }
        #endregion

        #region Métodos asíncronos
        public async Task<IEnumerable<LecturaResponse>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "BCPFLP_ResumenLecturasXUbicacion";
                var lectures = await connection.QueryAsync<LecturaResponse>(query, commandType: CommandType.StoredProcedure);
                return lectures;
            }
        }

        public async Task<IEnumerable<LecturaResponse>> GetAllErrorsAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "BCPFLP_ResumenLecturasConError";
                var lectures = await connection.QueryAsync<LecturaResponse>(query, commandType: CommandType.StoredProcedure);
                return lectures;
            }
        }

        public async Task<IEnumerable<RatioDeErrorResponse>> GetRatioErrorAsync(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "BCPFLP_RatioDeError";
                // Crear el parámetro para fechaDesde
                var paramDesde = new SqlParameter("@desde", SqlDbType.DateTime);
                paramDesde.Value = fechaDesde;

                // Crear el parámetro para fechaHasta
                var paramHasta = new SqlParameter("@hasta", SqlDbType.DateTime);
                paramHasta.Value = fechaHasta;

                // Ejecutar la consulta utilizando Dapper y pasar los parámetros
                var lectures = await connection.QueryAsync<RatioDeErrorResponse>(query, new { desde = fechaDesde, hasta = fechaHasta }, commandType: CommandType.StoredProcedure);
                return lectures;
            }
        }

        public async Task<IEnumerable<RatioDeErrorResponse>> GetRatioDeErrorByDeviceNameAsync(string deviceName, DateTime fechaDesde, DateTime fechaHasta)
        {

            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "BCPFLP_RatioDeErrorPorUbicacion";

                var paramDeviceName = new SqlParameter("@dispositivo", SqlDbType.NVarChar);
                paramDeviceName.Value = deviceName;

                // Crear el parámetro para fechaDesde
                var paramDesde = new SqlParameter("@desde", SqlDbType.DateTime);
                paramDesde.Value = fechaDesde;

                // Crear el parámetro para fechaHasta
                var paramHasta = new SqlParameter("@hasta", SqlDbType.DateTime);
                paramHasta.Value = fechaHasta;

                // Ejecutar la consulta utilizando Dapper y pasar los parámetros
                var lectures = await connection.QueryAsync<RatioDeErrorResponse>(query, new { dispositivo = deviceName, desde = fechaDesde, hasta = fechaHasta }, commandType: CommandType.StoredProcedure);
                return lectures;
            }
        }

        public async Task<Dispositivo> GetDispositivoAsync(string deviceName)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "select * from Dispositivos where nombre = @nombre";

                var paramDeviceName = new SqlParameter("@nombre", SqlDbType.NVarChar);
                paramDeviceName.Value = deviceName;

                var device = await connection.QuerySingleAsync<Dispositivo>(query, new { nombre = deviceName });
                return device;
            }
        }

        public async Task<IEnumerable<RastreoCajaResponse>> GetRastreoCajaAsync(string barcode)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "BCPFLP_RastreoCaja";

                var paramBarcode = new SqlParameter("@codigoBarra", SqlDbType.NVarChar);
                paramBarcode.Value = barcode;

                var rastreo = await connection.QueryAsync<RastreoCajaResponse>(query, new { codigoBarra = barcode }, commandType: CommandType.StoredProcedure);
                return rastreo;
            }
        }
        #endregion
    }
}
