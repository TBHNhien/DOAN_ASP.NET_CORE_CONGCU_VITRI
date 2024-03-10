using System;
using System.Collections.Generic;

namespace DOAN.Models;

public partial class ContentTag
{
    public long ContentId { get; set; }

    public string TagId { get; set; } = null!;
}
