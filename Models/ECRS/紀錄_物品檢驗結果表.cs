using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 紀錄_物品檢驗結果表
{
    public int 物品檢驗結果紀錄編號 { get; set; }

    public int? 已完成物品稽查編號 { get; set; }

    public int? 物品檢驗編號 { get; set; }

    public int? 物品稽查編號 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 檢查件數 { get; set; }

    public string? LIMS_主類編號 { get; set; }

    public string? LIMS_次類編號 { get; set; }

    public string? LIMS_細類編號 { get; set; }

    public string? 檢驗結果值 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 檢驗系統結果判定 { get; set; }

    public string? 判斷LIMS系統是否接入 { get; set; }

    public string? 批號 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員 { get; set; }

    public string? 畫面物件資料綜合列表 { get; set; }

    public int? 上一個完成的物品稽查編號 { get; set; }
}
