using AutoMapper;
using FLP.DashboardScanners.Aplicacion.DTO;
using FLP.DashboardScanners.Aplicacion.Interface;
using FLP.DashboardScanners.Domino.Entity;
using FLP.DashboardScanners.Interface;
using FPL.DashboardScanners.Transversal.Common;

namespace FLP.DashboardScanners.Aplicacion.Main
{
    public class LecturaResponseAplicacion : ILecturaResponseAplicacion
    {
        private readonly ILecturaResponseDomain _lecturaResponseDomain;
        private readonly IMapper _mapper;

        public LecturaResponseAplicacion(ILecturaResponseDomain lecturaResponseDomain, IMapper mapper)
        {
            _lecturaResponseDomain = lecturaResponseDomain;
            _mapper = mapper;
        }

        #region Métodos síncronos
        public Response<IEnumerable<LecturaResponseDto>> GetAll()
        {
            var response = new Response<IEnumerable<LecturaResponseDto>>();
            try
            {
                var lectures = _lecturaResponseDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<LecturaResponseDto>>(lectures);
                if(response.Data != null)
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

        public Response<IEnumerable<LecturaResponseDto>> GetAllErrors()
        {
            var response = new Response<IEnumerable<LecturaResponseDto>>();
            try
            {
                var lectures = _lecturaResponseDomain.GetAllErrors();
                response.Data = _mapper.Map<IEnumerable<LecturaResponseDto>>(lectures);
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

        #region Métdos asíncronos
        public async Task<Response<IEnumerable<LecturaResponseDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<LecturaResponseDto>>();
            try
            {
                var lectures = await _lecturaResponseDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<LecturaResponseDto>>(lectures);
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

        public async Task<Response<IEnumerable<LecturaResponseDto>>> GetAllErrorsAsync()
        {
            var response = new Response<IEnumerable<LecturaResponseDto>>();
            try
            {
                var lectures = await _lecturaResponseDomain.GetAllErrorsAsync();
                response.Data = _mapper.Map<IEnumerable<LecturaResponseDto>>(lectures);
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
