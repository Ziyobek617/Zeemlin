using Microsoft.AspNetCore.Mvc;
using Zeemlin.Service.DTOs.ScienceTeachers;
using Zeemlin.Service.DTOs.Users.SuperAdmins;
using Zeemlin.Service.Interfaces.Users;

namespace Zeemlin.Api.Controllers.Users;

public class SuperAdminsController : BaseController
{
    private readonly ISuperAdminService SuperAdminService;

    public SuperAdminsController(ISuperAdminService superAdminService)
    {
        SuperAdminService = superAdminService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SuperAdminForCreationDto dto)
        => Ok(await SuperAdminService.CreateAsync(dto));

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await this.SuperAdminService.RetrieveAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
        => Ok(await this.SuperAdminService.RetrieveByIdAsync(id));

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
        => Ok(await this.SuperAdminService.RemoveAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] SuperAdminForUpdateDto dto)
        => Ok(await this.SuperAdminService.ModifyAsync(id, dto));
}
