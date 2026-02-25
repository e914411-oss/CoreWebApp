using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件填寫歷程回覆答案_Event_Answer
{
    public int Event_Answer_Id { get; set; }

    public int Event_Question_Id { get; set; }

    public int Event_Main_Id { get; set; }

    public string? Answer { get; set; }

    public DateTime? ModDate { get; set; }

    public string? ModUser { get; set; }
}
