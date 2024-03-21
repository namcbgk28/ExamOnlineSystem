using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string? FullName { get; set; }

    public bool? Gender { get; set; }

    public DateTime? Dob { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<ClassSubject> ClassSubjects { get; set; } = new List<ClassSubject>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<TestDetail> TestDetails { get; set; } = new List<TestDetail>();
}
