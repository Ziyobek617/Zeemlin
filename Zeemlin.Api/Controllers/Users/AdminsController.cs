using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.Users.Admins;
using Zeemlin.Service.Interfaces.Users;

namespace Zeemlin.Api.Controllers.Users;

public class AdminsController : BaseController
{
    private readonly IAdminService adminService;

    public AdminsController(IAdminService adminService)
    {
        this.adminService = adminService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] AdminForCreationDto dto)
        => Ok(await adminService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this.adminService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this.adminService.RetrieveByIdAsync(id));

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this.adminService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] AdminForUpdateDto dto)
        => Ok(await this.adminService.ModifyAsync(id, dto));
}
