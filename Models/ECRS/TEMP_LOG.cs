using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class TEMP_LOG
{
    public int Id { get; set; }

    public string? SP_Name { get; set; }

    public string? Message { get; set; }

    public string? Parameter { get; set; }

    public DateTime? CreateDate { get; set; }
}
