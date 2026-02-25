using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 教育部查詢聯合稽查紀錄表
{
    public int 系統編號 { get; set; }

    public string 檔案種類 { get; set; } = null!;

    public string 原始檔名 { get; set; } = null!;

    public int 稽查年度 { get; set; }

    public string 縣市別 { get; set; } = null!;

    public string 學校統編 { get; set; } = null!;

    public string 團膳業者統編 { get; set; } = null!;

    public string 流水號 { get; set; } = null!;

    public string 檔案類型 { get; set; } = null!;

    public byte[] 檔案內容 { get; set; } = null!;

    public DateTime 更新日期 { get; set; }
}
