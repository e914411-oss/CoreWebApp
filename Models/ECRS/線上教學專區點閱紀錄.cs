using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 線上教學專區點閱紀錄
{
    public int 點閱紀錄編號 { get; set; }

    public int 課程編號 { get; set; }

    public DateTime? 點閱時間 { get; set; }

    public string? 點閱人員 { get; set; }
}
