using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 焦點快訊_發布對象表_News_Target
{
    public int NewsId { get; set; }

    public string Target { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
