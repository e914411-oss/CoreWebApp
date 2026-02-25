using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 行政處分明細表
{
    public int 系統編號 { get; set; }

    public int? 類型 { get; set; }

    public int? 各類型之系統編號 { get; set; }

    public string? 衛生局 { get; set; }

    public DateOnly? 發文日期 { get; set; }

    public string? 發文字號_號 { get; set; }

    public string? 主旨 { get; set; }

    public string? 處分對象_舊 { get; set; }

    public string? 受處分人 { get; set; }

    public string? 負責人 { get; set; }

    public string? 受處分人營業地址 { get; set; }

    public int? 統一編號 { get; set; }

    public string? 身分證字號 { get; set; }

    public DateOnly? 出生日期 { get; set; }

    public string? 性別 { get; set; }

    public string? 戶籍地址 { get; set; }

    public string? 處分書送達地址 { get; set; }

    public string? 聯絡電話 { get; set; }

    public string? 違反法規_舊 { get; set; }

    public int? 罰緩 { get; set; }

    public string? 違規事實 { get; set; }

    public string? 裁處理由 { get; set; }

    public string? 狀態 { get; set; }

    public string? 衛生局編號 { get; set; }

    public int? 發文字號類型 { get; set; }

    public string? 發文字號_字 { get; set; }

    public int? 處分對象種類 { get; set; }

    public string? 行政處分_是否停權 { get; set; }

    public int? 行政處分_停權類別 { get; set; }

    public string? 行政處分_停權類別其他內容 { get; set; }

    public DateOnly? 行政處分_停權日期起 { get; set; }

    public DateOnly? 行政處分_停權日期迄 { get; set; }

    public int? 行政處分_停權沒入保證金 { get; set; }

    public string? 行政處分_是否撤銷廢止 { get; set; }

    public string? 行政處分_是否罰鍰 { get; set; }

    public string? 備註 { get; set; }

    public string? 是否為移外縣市新增 { get; set; }

    public int? 移外事件紀錄檔編號 { get; set; }

    public string? 發文機關單位代碼 { get; set; }

    public string? 發文機關縣市代碼 { get; set; }

    public int? 稽查事件代碼 { get; set; }

    public string? 是否為裁處管理新增 { get; set; }
}
