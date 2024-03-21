using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Exam
{
    public int ExamId { get; set; }

    public string? ExamName { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<Test> Tests { get; set; } = new List<Test>();
}
