using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件填報頻率每週通知_Event_Report_Week
{
    public int Event_Report_Week_Id { get; set; }

    public int Event_Main_Id { get; set; }

    public string? Report_Week { get; set; }

    public DateOnly? Report_Week_Start { get; set; }

    public DateOnly? Report_Week_End { get; set; }

    public string? Report_FileName_Week { get; set; }
}
