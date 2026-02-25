using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_承諾_放行_主表
{
    public int 主表主鍵 { get; set; }

    public string? 外鍵 { get; set; }

    public string? 報案序號 { get; set; }

    public string? 公司名稱 { get; set; }

    public string? 承諾衛生局 { get; set; }

    public string? 承諾地址 { get; set; }

    public string? 產品名稱 { get; set; }

    public string? 檢查結果 { get; set; }

    public DateTime? 受理日期 { get; set; }

    public string? 報案義務人 { get; set; }

    public string? 牌名 { get; set; }

    public string? 進口日期 { get; set; }

    public string? 申報單編號 { get; set; }

    public string? 放行日期 { get; set; }

    public string? 檢查日期 { get; set; }

    public string? 案件受理理由 { get; set; }

    public string? 聯絡人 { get; set; }

    public string? 聯絡人電子信箱 { get; set; }

    public string? 聯絡人電話號碼 { get; set; }

    public string? 聯絡人傳真號碼 { get; set; }

    public string? 聯絡人手機號碼 { get; set; }

    public string? 承諾日期 { get; set; }

    public string? 開始裝船日期 { get; set; }

    public string? 到達日期 { get; set; }

    public string? 預計交貨日期 { get; set; }

    public string? 複驗結果 { get; set; }

    public string? 交易對象 { get; set; }

    public string? 交易日期 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 標註 { get; set; }

    public string? 產品編號 { get; set; }

    public string? 產品中文名稱 { get; set; }

    public string? 產品規格 { get; set; }

    public string? 產品英文名稱 { get; set; }

    public string? 產品製造國家 { get; set; }

    public string? 內裝數量 { get; set; }

    public string? 申報數量 { get; set; }

    public int 產品表主鍵 { get; set; }

    public int? CN_Len { get; set; }
}
