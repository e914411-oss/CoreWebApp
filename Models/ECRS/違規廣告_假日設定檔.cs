using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_假日設定檔
{
    public DateTime? 客製化假日 { get; set; }

    public string? 當日是否工作 { get; set; }

    public string? 備註 { get; set; }

    public int 假日流水號 { get; set; }
}
