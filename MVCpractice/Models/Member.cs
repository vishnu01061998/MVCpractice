using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCpractice.Models;

public partial class Member
{
    public int Id { get; set; }

    [Required]

    public string? Name { get; set; }

    [Required]
    public int? Age { get; set; }

    [Required]
    public string? Mobile { get; set; }

    [Required]
    public string? Duration { get; set; }

    [Required]
    public DateTime? JoiningDate { get; set; }

    [Required]
    public string? Gender { get; set; }
}
