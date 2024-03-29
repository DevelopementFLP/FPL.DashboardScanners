using AutoMapper;
using FLP.DashboardScanners.Aplicacion.DTO;
using FLP.DashboardScanners.Aplicacion.Interface;
using FLP.DashboardScanners.Dominio.Interface;
using FLP.DashboardScanners.Interface;
using FPL.DashboardScanners.Transversal.Common;

namespace FLP.DashboardScanners.Aplicacion.Main
{
    public class DispositivoAplicacion : IDispositivoAplicacion
    {
        private readonly IDispositivoDomain _dispositivoDomain;
        private readonly IMapper _mapper;

        public DispositivoAplicacion(IDispositivoDomain dispositivoDomain, IMapper mapper)
        {
            _dispositivoDomain = dispositivoDomain;
            _mapper = mapper;
        }

        #region Métodos síncronos
        public Response<DispositivoResponseDto> GetDispositivo(string deviceName)
        {
            var response = new Response<DispositivoResponseDto>();
            try
            {
                var lectures = _dispositivoDomain.GetDispositivo(deviceName);
                response.Data = _mapper.Map<DispositivoResponseDto>(lectures);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa.";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }
        #endregion

        #region Métodos asíncronos
        public async Task<Response<DispositivoResponseDto>> GetDispositivoAsync(string deviceName)
        {
            var response = new Response<DispositivoResponseDto>();
            try
            {
                var lectures = await _dispositivoDomain.GetDispositivoAsync(deviceName);
                response.Data = _mapper.Map<DispositivoResponseDto>(lectures);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa.";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }
        #endregion
    }
}
