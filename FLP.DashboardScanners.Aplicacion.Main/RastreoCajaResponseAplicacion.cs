using AutoMapper;
using FLP.DashboardScanners.Aplicacion.DTO;
using FLP.DashboardScanners.Aplicacion.Interface;
using FLP.DashboardScanners.Dominio.Interface;
using FPL.DashboardScanners.Transversal.Common;

namespace FLP.DashboardScanners.Aplicacion.Main
{
    public class RastreoCajaResponseAplicacion : IRastreoCajaResponseAplicacion
    {
        private readonly IRastreoCajaDomain _rastreoCajaDomain;
        private readonly IMapper _mapper;

        public RastreoCajaResponseAplicacion(IRastreoCajaDomain rastreoCajaDomain, IMapper mapper)
        {
            _rastreoCajaDomain = rastreoCajaDomain;
            _mapper = mapper;
        }


        #region Métodos síncronos
        public Response<IEnumerable<RastreoCajaResponseDto>> GetRastreoCaja(string barcode)
        {
            var response = new Response<IEnumerable<RastreoCajaResponseDto>>();
            try
            {
                var lectures = _rastreoCajaDomain.GetRastreoCaja(barcode);
                response.Data = _mapper.Map<IEnumerable<RastreoCajaResponseDto>>(lectures);
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
        public async Task<Response<IEnumerable<RastreoCajaResponseDto>>> GetRastreoCajaAsync(string barcode)
        {
            var response = new Response<IEnumerable<RastreoCajaResponseDto>>();
            try
            {
                var lectures = await _rastreoCajaDomain.GetRastreoCajaAsync(barcode);
                response.Data = _mapper.Map<IEnumerable<RastreoCajaResponseDto>>(lectures);
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
