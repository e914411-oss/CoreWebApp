using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_抽樣紀錄_ForASEFSC
{
    public int 抽樣案號 { get; set; }

    public string? 樣品編號 { get; set; }

    public string? 樣品名稱 { get; set; }

    public DateTime? 樣品抽樣日期 { get; set; }

    public DateOnly? 樣品有效日期 { get; set; }

    public DateOnly? 樣品製造日期 { get; set; }

    public string? 樣品批號 { get; set; }

    public string? 衛生局 { get; set; }

    public string? 抽樣人員帳號 { get; set; }

    public string? 抽樣人員姓名 { get; set; }

    public string? 抽樣結果 { get; set; }
}
