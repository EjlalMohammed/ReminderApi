using Application.BusinessServices;
using Application.Common;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using ReservePro.Management.Api.Controllers;

namespace ReservePro.Managemant.Api
{
    public class RoleController(IRoleService service, ILogger<BaseController> _logger) : BaseController(_logger)
    {
        private readonly IRoleService _service = service;
        [HttpGet]

        public async Task<ActionResult<Results<IEnumerable<RoleDTO>>>> Get()
        {
            try
            {
                return await _service.GetAllAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ErrorResult.Failed(ServiceError.CustomMessage($"ExpMsg: {ex.Message}. {(ex.InnerException != null ? "InnerMsg: " + ex.InnerException.Message : "")}")));
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Results<RoleDTO>>> Get(Guid id)
        {
            try
            {
                return await _service.GetByIdAsync(id);

            }
            catch (Exception ex)
            {
                //logger.LogError(ex, "");
                return StatusCode(500, ErrorResult.Failed(ServiceError.CustomMessage($"ExpMsg: {ex.Message}. {(ex.InnerException != null ? "InnerMsg: " + ex.InnerException.Message : "")}")));
            }
        }

       

    }
}
