using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 訂席_外燴定型化契約稽查
{
    public int 訂席_外燴定型化契約稽查序號 { get; set; }

    public int 稽查序號 { get; set; }

    public string 有無使用定型化契約 { get; set; } = null!;

    public string 目前人員 { get; set; } = null!;

    public string 稽查結果 { get; set; } = null!;

    public DateOnly? 限期改善日期 { get; set; }

    public decimal? 罰款金額 { get; set; }

    public string 稽查進度 { get; set; } = null!;

    public string 稽查員 { get; set; } = null!;

    public string 承辦員 { get; set; } = null!;

    public string 審查員 { get; set; } = null!;

    public string 是否結案 { get; set; } = null!;

    public DateTime? 結案日期 { get; set; }

    public int 上一次稽查序號 { get; set; }

    public int 複查筆數 { get; set; }

    public int 最初稽查序號 { get; set; }

    public string 備註 { get; set; } = null!;

    public DateTime 建立日期 { get; set; }

    public string 建立人員 { get; set; } = null!;

    public DateTime 更新日期 { get; set; }

    public string 更新人員 { get; set; } = null!;

    public string? 處分情形_是否輔導改善 { get; set; }

    public string? 處分情形_是否移外縣市 { get; set; }

    public DateOnly? 移外縣市_函送日期 { get; set; }

    public string? 移外縣市_函送文號 { get; set; }

    public string? 移外縣市_移外縣市 { get; set; }

    public string? 移外縣市_市招名稱 { get; set; }

    public string? 移外縣市_負責人 { get; set; }

    public string? 移外縣市_業者地址 { get; set; }

    public string? 移外縣市_移外原因 { get; set; }

    public string? 是否已移出 { get; set; }

    public string? 違反法條_消費者保護法第十七條第一項 { get; set; }

    public DateOnly? 處分情形_限期改善日期 { get; set; }

    public string? 處分情形_是否限期改善 { get; set; }

    public string? 處分情形_是否行政罰鍰 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }
}
