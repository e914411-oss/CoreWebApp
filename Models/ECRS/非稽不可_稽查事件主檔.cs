using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_稽查事件主檔
{
    public int 稽查事件流水編號 { get; set; }

    public string? 縣市代碼檔 { get; set; }

    public int? 業者編號 { get; set; }

    public string? 業別主分類 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 稽查日期民國 { get; set; }

    public string? 稽查日期時分 { get; set; }

    public string? 限定完成日民國 { get; set; }

    public DateOnly? 限定完成日 { get; set; }

    public string? 此案件是否為複查案件 { get; set; }

    public DateOnly? 複查日期 { get; set; }

    public string? 複查日期民國 { get; set; }

    public string? 輔導日期 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 結案狀態 { get; set; }

    public string? 備註0 { get; set; }

    public string? 受檢業者代表人 { get; set; }

    public string? 稽查員 { get; set; }

    public string? 稽查員姓名 { get; set; }

    public string? 承辦人 { get; set; }

    public string? 審查員 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 介面異動時間 { get; set; }

    public string? 異動日期 { get; set; }

    public DateTime? 資料傳送時間 { get; set; }

    public string? 建立人 { get; set; }

    public string? 刪除註記 { get; set; }

    public string? 備註1 { get; set; }

    public DateOnly? 結案日期_介接_ { get; set; }

    public string? 結案日期_介接_民國 { get; set; }

    public int? 複查編號 { get; set; }

    public int? 複查次數 { get; set; }

    public int? 稽查編號 { get; set; }

    public string? 介面異動者 { get; set; }
}
