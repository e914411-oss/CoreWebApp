using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_非登需補登資料業者清單
{
    public string? 公司登錄字號 { get; set; }

    public string? 公司_商業名稱 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 實際營業地址_縣市 { get; set; }

    public string? 實際營業地址_區域 { get; set; }

    public string? 實際營業地址_街道 { get; set; }

    public string? 登記地址_縣市 { get; set; }

    public string? 登記地址_區域 { get; set; }

    public string? 登記地址_街道 { get; set; }

    public string 負責人 { get; set; } = null!;

    public string? 統編_編號 { get; set; }

    public string? 業別 { get; set; }

    public string? 非登資料待補登情形 { get; set; }
}
