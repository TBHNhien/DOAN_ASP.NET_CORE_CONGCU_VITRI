using System;
using System.Collections.Generic;

namespace DOAN.Models;

public partial class Footer
{
    public string Id { get; set; } = null!;

    public string? Content { get; set; }

    public bool? Status { get; set; }
}
