using Microsoft.AspNetCore.Mvc;
using Zeemlin.Domain.Entities;
using Zeemlin.Service.Interfaces;

namespace Zeemlin.Api.Controllers;

public class EmailsController : BaseController
{
    private readonly IEmailService _emailService;
    public EmailsController(IEmailService emailService)
    {
        this._emailService = emailService;
    }

    [HttpPost]
    public async Task<IActionResult> SendMessageAsync(Message message)
    {
        await this._emailService.SendMessage(message);
        return Ok();
    }
}
