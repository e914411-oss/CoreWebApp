using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 派案_通路藥品回收稽查明細表
{
    public int 通路藥品回收明細表編號 { get; set; }

    public int? 通路藥品回收主表編號 { get; set; }

    public string? 受貨者名稱 { get; set; }

    public string? 地址_縣市 { get; set; }

    public string? 地址_區域 { get; set; }

    public string? 地址_地址 { get; set; }

    public DateOnly? 出廠日期 { get; set; }

    public string? 批號或型號 { get; set; }

    public int? 銷售數量 { get; set; }

    public int? 使用者通報數量_合格 { get; set; }

    public int? 使用者通報數量_不合格 { get; set; }

    public string? 縣市編號 { get; set; }

    public string? 稽查隊長編號 { get; set; }

    public string? 承辦人員編號 { get; set; }

    public string? 建立人員編號 { get; set; }

    public string? 異動人員 { get; set; }

    public DateTime? 異動時間 { get; set; }
}
