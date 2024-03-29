using Microsoft.AspNetCore.Mvc;
using FLP.DashboardScanners.Aplicacion.Interface;

namespace FLP.DashboardScanners.Servicio.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecturaResponseController : ControllerBase
    {
        private readonly ILecturaResponseAplicacion _lecturaResponseAplication;
        private readonly IRatioDeErrorResponseAplicacion _ratioErrorResponseAplication;
        private readonly IDispositivoAplicacion _dispositivoAplication;
        private readonly IRastreoCajaResponseAplicacion _rastreoCajaResponseAplication;

        public LecturaResponseController(
            ILecturaResponseAplicacion lecturaResponseAplication,
            IRatioDeErrorResponseAplicacion ratioResponseAplication,
            IDispositivoAplicacion dispositivoAplicacion,
            IRastreoCajaResponseAplicacion rastreoResponseAplication
        )
        {
            _lecturaResponseAplication = lecturaResponseAplication;
            _ratioErrorResponseAplication = ratioResponseAplication;
            _dispositivoAplication = dispositivoAplicacion;
            _rastreoCajaResponseAplication = rastreoResponseAplication;
        }

        #region Métodos síncronos
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var response = _lecturaResponseAplication.GetAll();
            if(response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetAllErrors")]
        public IActionResult GetAllErrors()
        {
            var response = _lecturaResponseAplication.GetAllErrors();
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetErrorRatio")]
        public IActionResult GetErrorRatio(DateTime fechaDesde, DateTime fechaHasta)
        {
            var response = _ratioErrorResponseAplication.GetRatioError(fechaDesde, fechaHasta);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetErrorRatioByDeviceName")]
        public IActionResult GetErrorRatioByDeviceName(string dispositivo, DateTime fechaDesde, DateTime fechaHasta)
        {
            var response = _ratioErrorResponseAplication.GetRatioDeErrorByDeviceName(dispositivo, fechaDesde, fechaHasta);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetDispositivo")]
        public IActionResult GetDispositivo(string dispositivo) 
        {
            var response = _dispositivoAplication.GetDispositivo(dispositivo);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetRastreoCaja")]
        public IActionResult GetRastreoCaja(string barcode)
        {
            var response = _rastreoCajaResponseAplication.GetRastreoCaja(barcode);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }
        #endregion

        #region Métodos asíncronos
        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _lecturaResponseAplication.GetAllAsync();
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetAllErrorsAsync")]
        public async Task<IActionResult> GetAllErrorsAsync()
        {
            var response = await _lecturaResponseAplication.GetAllErrorsAsync();
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetErrorRatioAsync")]
        public async Task<IActionResult> GetErrorRatioAsync(DateTime fechaDesde, DateTime fechaHasta)
        {
            var response = await _ratioErrorResponseAplication.GetRatioErrorAsync(fechaDesde, fechaHasta);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetErrorRatioByDeviceNameAsync")]
        public async Task<IActionResult> GetErrorRatioByDeviceNameAsync(string dispositivo, DateTime fechaDesde, DateTime fechaHasta)
        {
            var response = await _ratioErrorResponseAplication.GetRatioDeErrorByDeviceNameAsync(dispositivo, fechaDesde, fechaHasta);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetDispositivoAsync")]
        public async Task<IActionResult> GetDispositivoAsync(string dispositivo)
        {
            var response = await _dispositivoAplication.GetDispositivoAsync(dispositivo);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetRastreoCajaAsync")]
        public async Task<IActionResult> GetRastreoCajaAsync(string barcode)
        {
            var response = await _rastreoCajaResponseAplication.GetRastreoCajaAsync(barcode);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }
        #endregion
    }
}
