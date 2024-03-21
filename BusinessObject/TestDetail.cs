using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class TestDetail
{
    public int QuestionId { get; set; }

    public int TestId { get; set; }

    public int? OptionChoosen { get; set; }

    public string UserId { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;

    public virtual Test Test { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
