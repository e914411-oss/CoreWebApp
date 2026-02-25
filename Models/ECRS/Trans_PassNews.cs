using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class Trans_PassNews
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Content { get; set; }

    public DateTime? SDate { get; set; }

    public DateTime? EDate { get; set; }

    public string? IsPublish { get; set; }

    public string? Publish_Target { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? LastEditTime { get; set; }

    public int? TifsanId { get; set; }
}
