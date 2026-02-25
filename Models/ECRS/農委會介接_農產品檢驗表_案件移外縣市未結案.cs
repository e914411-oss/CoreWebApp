using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 農委會介接_農產品檢驗表_案件移外縣市未結案
{
    public int 物品稽查編號 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public DateOnly? 物品稽查建立日期 { get; set; }

    public string? 機構代號 { get; set; }

    public string? 被抽樣單位 { get; set; }

    public string? 被抽樣縣市 { get; set; }

    public string? 被抽樣鄉鎮 { get; set; }

    public string? 被抽樣地址 { get; set; }

    public string? 被抽樣電話 { get; set; }

    public string? 產品國別 { get; set; }

    public DateOnly? 製造日期 { get; set; }

    public string? 檢體批號 { get; set; }

    public int 檢體編號 { get; set; }

    public string? 檢體名稱 { get; set; }

    public string? 檢體標準名稱 { get; set; }

    public string? 檢體類別 { get; set; }

    public string? 檢體總判定 { get; set; }

    public string? 來源業者名稱 { get; set; }

    public string? 來源業者地址 { get; set; }

    public string? 來源業者電話 { get; set; }

    public string? 製造業者名稱 { get; set; }

    public string? 製造業者地址 { get; set; }

    public string? 製造業者電話 { get; set; }

    public string? 備註 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public string? 處理情形_移其他單位辦理 { get; set; }

    public string? 處理情形_移外縣市 { get; set; }

    public string? 處理情形_移送法院 { get; set; }

    public string? 處理情形_停業 { get; set; }

    public string? 處理情形_罰款金額 { get; set; }

    public string? 處理情形_廢棄重量_公斤 { get; set; }

    public string? 處理情形_禁止出售或沒收 { get; set; }

    public string? 處理情形_飭其收回重製 { get; set; }

    public string? 結案日期 { get; set; }

    public string? 結案狀態 { get; set; }
}
