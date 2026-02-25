using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 焦點快訊_附件表_New_File
{
    public int Id { get; set; }

    public int NewsId { get; set; }

    public string? FilePath { get; set; }

    public string? Create_ID { get; set; }

    public DateTime? Create_Time { get; set; }

    public DateTime? Upd_Time { get; set; }

    public byte[]? File_Data { get; set; }
}
