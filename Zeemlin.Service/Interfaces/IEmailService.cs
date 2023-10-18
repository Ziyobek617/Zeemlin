using Zeemlin.Domain.Entities;

namespace Zeemlin.Service.Interfaces;

public interface IEmailService
{
    public Task SendMessage(Message message);

}
