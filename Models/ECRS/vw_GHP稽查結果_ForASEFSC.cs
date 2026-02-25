using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_GHP稽查結果_ForASEFSC
{
    public int GHP案號 { get; set; }

    public string? 廠商統編 { get; set; }

    public string? 廠商名稱 { get; set; }

    public string? 廠商地址 { get; set; }

    public string? 稽查結果 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 衛生局 { get; set; }

    public string? 稽查人員帳號 { get; set; }

    public string? 稽查人員姓名 { get; set; }

    public string? 食品業者登入字號 { get; set; }

    public string? 工廠登記號碼 { get; set; }
}
