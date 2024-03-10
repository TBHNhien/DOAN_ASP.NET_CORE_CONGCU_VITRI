using System;
using System.Collections.Generic;

namespace DOAN.Models;

public partial class Content
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? MetaTitle { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public long? CategoryId { get; set; }

    public string? Detail { get; set; }

    public int? Warranty { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? MetaKeywords { get; set; }

    public bool? Status { get; set; }

    public DateTime? TopHot { get; set; }

    public int? ViewCount { get; set; }

    public string? Tags { get; set; }
}
