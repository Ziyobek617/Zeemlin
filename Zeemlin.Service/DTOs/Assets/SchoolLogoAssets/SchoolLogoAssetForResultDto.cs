﻿using Zeemlin.Service.DTOs.Schools;

namespace Zeemlin.Service.DTOs.Assets.SchoolLogoAssets;

public class SchoolLogoAssetForResultDto
{
    public long Id { get; set; }
    public string Path { get; set; }
    public DateTime UploadedDate { get; set; }
    public long SchoolId { get; set; }
    public SchoolForResultDto School { get; set; }
}
