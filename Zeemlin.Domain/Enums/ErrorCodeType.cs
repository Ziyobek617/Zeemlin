using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeemlin.Domain.Enums;

public enum ErrorCodeType
{
    // Image-specific errors
    ImageTooLarge,
    InvalidImageFormat,
    ImageUploadFailed,
    ImageUpdateFailed,
    ImageDeleteFailed,
    ImageNotFound,
    ImageValidationFailed, // General validation error

    // Additional generic errors (if applicable)
    UnauthorizedAccess,
    InternalServerError,
    ResourceNotFound, // For other resources related to images
}
