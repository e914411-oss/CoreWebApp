using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件填報頻率每月通知_Event_Report_Month
{
    public int Event_Report_Month_Id { get; set; }

    public int Event_Main_Id { get; set; }

    public string? Report_Month { get; set; }

    public DateOnly? Report_Month_Start { get; set; }

    public DateOnly? Report_Month_End { get; set; }

    public string? Report_FileName_Month { get; set; }
}
