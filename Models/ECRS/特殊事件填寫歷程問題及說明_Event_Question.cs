using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件填寫歷程問題及說明_Event_Question
{
    public int Event_Question_Id { get; set; }

    public int? Event_Main_Id { get; set; }

    public string? Title { get; set; }

    public string? Illustrate { get; set; }

    public string? Reported_Type { get; set; }

    public DateTime? ModDate { get; set; }

    public string? ModUser { get; set; }

    public int? Sort { get; set; }
}
