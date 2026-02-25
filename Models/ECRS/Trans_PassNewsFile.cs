using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class Trans_PassNewsFile
{
    public int Id { get; set; }

    public int PassNewsId { get; set; }

    public byte[]? FileImg { get; set; }

    public string? FileName { get; set; }

    public int? FileSize { get; set; }

    public int? tifsanFileId { get; set; }

    public DateTime? Upd_Time { get; set; }
}
