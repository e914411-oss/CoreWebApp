using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_非登無場所登錄字號匯入清單
{
    public string? 食品業者業別 { get; set; }

    public string? 食品業者登錄字號 { get; set; }

    public string? 公司_商業名稱 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 工廠登記編號 { get; set; }

    public string? 營業地址_縣市 { get; set; }

    public string? 營業地址_區域 { get; set; }

    public string? 營業地址_街道 { get; set; }

    public string? 營登地址_縣市 { get; set; }

    public string? 營登地址_區域市 { get; set; }

    public string? 營登地址_街道 { get; set; }

    public string 負責人 { get; set; } = null!;

    public string 營業狀態 { get; set; } = null!;

    public string? 公司登錄字號 { get; set; }

    public string? 緊急聯絡人名稱 { get; set; }

    public string? 緊急聯絡人電子郵件 { get; set; }

    public string? 緊急聯絡人手機 { get; set; }

    public string? 非登系統登錄情形 { get; set; }
}
