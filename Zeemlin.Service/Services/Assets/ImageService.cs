using Zeemlin.Service.Exceptions;
using Zeemlin.Service.Interfaces.Assets;

namespace Zeemlin.Service.Services.Assets;

public class ImageService : IImageService
{
    public async Task DeleteImageAsync(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
        catch (Exception ex)
        {
            throw new ZeemlinException(500, "Error deleting image: " + ex.Message);
        }
    }
}

