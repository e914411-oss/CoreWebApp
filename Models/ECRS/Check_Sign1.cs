using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class Check_Sign1
{
    public int Id { get; set; }

    public int Check_List_ID { get; set; }

    public string? SignType { get; set; }

    public string? SignFileName { get; set; }

    public DateTime? Create_Time { get; set; }
}
