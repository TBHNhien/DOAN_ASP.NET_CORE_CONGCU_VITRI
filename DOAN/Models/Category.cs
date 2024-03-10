using System;
using System.Collections.Generic;

namespace DOAN.Models;

public partial class Category
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? MetaTitle { get; set; }

    public long? ParentId { get; set; }

    public int? DisplayOrder { get; set; }

    public string? SeoTitle { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescriptions { get; set; }

    public bool? Status { get; set; }

    public bool? ShowOnHome { get; set; }
}
