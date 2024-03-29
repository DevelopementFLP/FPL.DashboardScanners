using AutoMapper;
using FLP.DashboardScanners.Aplicacion.DTO;
using FLP.DashboardScanners.Aplicacion.Interface;
using FLP.DashboardScanners.Dominio.Interface;
using FPL.DashboardScanners.Transversal.Common;

namespace FLP.DashboardScanners.Aplicacion.Main
{
    public class RatioDeErrorResponseAplicacion : IRatioDeErrorResponseAplicacion
    {
        private readonly IRatioDeErrorDomain _ratioErrorDomain;
        private readonly IMapper _mapper;

        public RatioDeErrorResponseAplicacion(IRatioDeErrorDomain ratioErrorDomain, IMapper mapper)
        {
            _ratioErrorDomain = ratioErrorDomain;
            _mapper = mapper;
        }

        #region Métodos síncronos
        public Response<IEnumerable<RatioDeErrorResponseDto>> GetRatioError(DateTime fechaDesde, DateTime fechaHasta)
        {
            var response = new Response<IEnumerable<RatioDeErrorResponseDto>>();
            try
            {
                var lectures = _ratioErrorDomain.GetRatioError(fechaDesde, fechaHasta);
                response.Data = _mapper.Map<IEnumerable<RatioDeErrorResponseDto>>(lectures);
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

        public Response<IEnumerable<RatioDeErrorResponseDto>> GetRatioDeErrorByDeviceName(string deviceName, DateTime fechaDesde, DateTime fechaHasta)
        {
            var response = new Response<IEnumerable<RatioDeErrorResponseDto>>();
            try
            {
                var lectures = _ratioErrorDomain.GetRatioDeErrorByDeviceName(deviceName, fechaDesde, fechaHasta);
                response.Data = _mapper.Map<IEnumerable<RatioDeErrorResponseDto>>(lectures);
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
        public async Task<Response<IEnumerable<RatioDeErrorResponseDto>>> GetRatioErrorAsync(DateTime fechaDesde, DateTime fechaHasta)
        {
            var response = new Response<IEnumerable<RatioDeErrorResponseDto>>();
            try
            {
                var lectures = await _ratioErrorDomain.GetRatioErrorAsync(fechaDesde, fechaHasta);
                response.Data = _mapper.Map<IEnumerable<RatioDeErrorResponseDto>>(lectures);
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

        public async Task<Response<IEnumerable<RatioDeErrorResponseDto>>> GetRatioDeErrorByDeviceNameAsync(string deviceName, DateTime fechaDesde, DateTime fechaHasta)
        {
            var response = new Response<IEnumerable<RatioDeErrorResponseDto>>();
            try
            {
                var lectures = await _ratioErrorDomain.GetRatioDeErrorByDeviceNameAsync(deviceName, fechaDesde, fechaHasta);
                response.Data = _mapper.Map<IEnumerable<RatioDeErrorResponseDto>>(lectures);
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
