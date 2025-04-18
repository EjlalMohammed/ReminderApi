using Application.BusinessServices;
using Application.Common;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using ReservePro.Management.Api.Controllers;

namespace ReservePro.Managemant.Api
{
    public class RoleController(IUserService service, ILogger<BaseController> _logger) : BaseController(_logger)
    {
        private readonly IUserService _service = service;
        [HttpGet]

        public async Task<ActionResult<Results<IEnumerable<UserDTO>>>> Get()
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
        public async Task<ActionResult<Results<UserDTO>>> Get(Guid id)
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

        [HttpPost]
        public async Task<IActionResult> Post(UserDTO entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _service.InsertAsync(entity);
                    return StatusCode(200, SuccessResult.Success(ServiceSuccess.Default));
                }
                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                //logger.LogError(ex, "");
                return StatusCode(500, ErrorResult.Failed(ServiceError.CustomMessage($"ExpMsg: {ex.Message}. {(ex.InnerException != null ? "InnerMsg: " + ex.InnerException.Message : "")}")));
            }
        }


        [HttpPut]
        public async Task<IActionResult> Put(UserDTO entity)
        {
            try
            {
                await _service.UpdateAsync(entity);

                return StatusCode(200, SuccessResult.Success(ServiceSuccess.Default));

            }
            catch (Exception ex)
            {
                //logger.LogError(ex, "");
                return StatusCode(500, ErrorResult.Failed(ServiceError.CustomMessage($"ExpMsg: {ex.Message}. {(ex.InnerException != null ? "InnerMsg: " + ex.InnerException.Message : "")}")));
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return StatusCode(200, SuccessResult.Success(ServiceSuccess.Default));

            }
            catch (Exception ex)
            {
                //logger.LogError(ex, "");
                return StatusCode(500, ErrorResult.Failed(ServiceError.CustomMessage($"ExpMsg: {ex.Message}. {(ex.InnerException != null ? "InnerMsg: " + ex.InnerException.Message : "")}")));
            }
        }
    }
}
