using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Question
{
    public int QuestionId { get; set; }

    public string? QuestionContent { get; set; }

    public string? SubjectId { get; set; }

    public int? ExamId { get; set; }

    public virtual Exam? Exam { get; set; }

    public virtual ICollection<Option> Options { get; set; } = new List<Option>();

    public virtual Subject? Subject { get; set; }

    public virtual ICollection<TestDetail> TestDetails { get; set; } = new List<TestDetail>();
}
