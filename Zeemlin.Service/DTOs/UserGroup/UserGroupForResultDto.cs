using Zeemlin.Service.DTOs.Group;
using Zeemlin.Service.DTOs.User;

namespace Zeemlin.Service.DTOs.UserGroup;

public class UserGroupForResultDto
{
    public long Id { get; set; }
    public UserForResultDto User { get; set; }
    public GroupForResultDto Group{ get; set; }
}
