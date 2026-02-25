using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_待承辦清單
{
    public string? 稽查項目 { get; set; }

    public string? 稽查代號 { get; set; }

    public int 稽查編號 { get; set; }

    public int? 稽查事件編號 { get; set; }

    public string? 稽查人員編號 { get; set; }

    public string? 稽查人員 { get; set; }

    public string? 承辦人員編號 { get; set; }

    public string? 操作人員編號 { get; set; }

    public string? 稽查結果 { get; set; }

    public string 是否為審查退回案件 { get; set; } = null!;

    public string? 查核報告文號 { get; set; }

    public int? 檢驗結果 { get; set; }

    public int? 複查ID { get; set; }

    public string? 是否移外縣市 { get; set; }

    public string? 是否已移出 { get; set; }

    public string? 專案代號 { get; set; }

    public int? 業者代號 { get; set; }

    public string? 稽查日期 { get; set; }

    public string? 是否結案 { get; set; }

    public string? 許可證字號 { get; set; }

    public string? 主類別 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 稽查結果_抽驗 { get; set; }

    public string? 稽查結果_標示 { get; set; }

    public string? 稽查結果_熟食 { get; set; }

    public string? Is抽驗 { get; set; }

    public string? Is標示 { get; set; }

    public string? Is熟食 { get; set; }

    public string? Is油炸油 { get; set; }

    public string? 狀態確認 { get; set; }

    public string? 異動人員 { get; set; }

    public string? 物品編號 { get; set; }
}
