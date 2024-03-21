using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Subject
{
    public string SubjectId { get; set; } = null!;

    public string? SubjectName { get; set; }

    public virtual ICollection<ClassSubject> ClassSubjects { get; set; } = new List<ClassSubject>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<Test> Tests { get; set; } = new List<Test>();
}
