﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Teacher : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    [Phone]
    public string PhoneNumber { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [PasswordPropertyText]
    public string Password { get; set; }
    public string Biography { get; set; }
    [Required]
    [MaxLength(50)]
    public string DistrictName { get; set; }
    [Required]
    public long SchoolNumber { get; set; }
    public long? GroupId { get; set; }
    public Group Group { get; set; }
}
