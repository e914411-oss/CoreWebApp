using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處資料追繳記錄資料檔
{
    public int 追繳記錄系統編號 { get; set; }

    public int 裁處資料主檔編號 { get; set; }

    public string? 收據號碼 { get; set; }

    public DateOnly? 發文日期 { get; set; }

    public string? 追繳紀錄發文字號_字 { get; set; }

    public string? 追繳紀錄發文字號_號 { get; set; }

    public DateOnly? 繳款日期 { get; set; }

    public int? 繳款金額 { get; set; }

    public DateOnly? 下次繳款日期 { get; set; }

    public string? 繳款方式 { get; set; }

    public string? 繳款方式說明 { get; set; }
}
