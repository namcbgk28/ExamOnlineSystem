using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class ClassSubject
{
    public string SubjectId { get; set; } = null!;

    public int ClassId { get; set; }

    public string StudentId { get; set; } = null!;

    public virtual Class Class { get; set; } = null!;

    public virtual User Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
