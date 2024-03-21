using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Test
{
    public int TestId { get; set; }

    public string? TestCode { get; set; }

    public string? SubjectId { get; set; }

    public int? ExamId { get; set; }

    public int? PaperNo { get; set; }

    public bool? Status { get; set; }

    public int? TestTime { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? NumberOfQuestion { get; set; }

    public virtual Exam? Exam { get; set; }

    public virtual Subject? Subject { get; set; }

    public virtual ICollection<TestDetail> TestDetails { get; set; } = new List<TestDetail>();
}
