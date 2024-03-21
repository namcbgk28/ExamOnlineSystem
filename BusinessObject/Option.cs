using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Option
{
    public int? QuestionId { get; set; }

    public string? OptionContent { get; set; }

    public bool? RightAnswer { get; set; }

    public int OptionId { get; set; }

    public virtual Question? Question { get; set; }
}
