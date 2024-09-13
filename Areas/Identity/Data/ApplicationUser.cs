using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AuthSystem.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required]
    public string Name {  get; set; }

    [Required]
    public string IsoCode { get; set; }

    [Required]
    [Phone]
    public string Telephone { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }
}

