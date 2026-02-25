using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_案件處分作業
{
    public string 違規案件編號 { get; set; } = null!;

    public string 處分進度 { get; set; } = null!;

    public string 處分機關 { get; set; } = null!;

    public string 處分縣市 { get; set; } = null!;

    public string 違規事實 { get; set; } = null!;

    public string 違規廠商 { get; set; } = null!;

    public string 負責人 { get; set; } = null!;

    public DateTime? 業者_處分日期 { get; set; }

    public DateTime? 代言人_處分日期 { get; set; }

    public DateTime? 傳播媒體_處分日期 { get; set; }

    public DateTime 處分日期 { get; set; }

    public string? 處分法條 { get; set; }

    public string? 代言人_處分法規 { get; set; }

    public string? 傳播媒體_處分法規 { get; set; }

    public string? 業者_處分法規 { get; set; }

    public int? 業者_處分金額 { get; set; }

    public int? 代言人_處分金額 { get; set; }

    public int? 處分媒體_處分金額 { get; set; }

    public int 處分金額 { get; set; }

    public string? 罰款分配 { get; set; }

    public string? 處分傳播媒體_罰款分配 { get; set; }

    public string? 處分薦證代言人_罰款分配 { get; set; }

    public string? 處分廣告託播業者_罰款分配 { get; set; }

    public string? 處分字號 { get; set; }

    public string? 處分薦證代言人_處分字號 { get; set; }

    public string? 處分傳播媒體_處分字號 { get; set; }

    public string? 處分廣告託播業者_處分字號 { get; set; }

    public string 違規內容 { get; set; } = null!;

    public string? 受處罰媒體 { get; set; }

    public int 查處情形 { get; set; }

    public string? 查處情形_輔導文號 { get; set; }

    public string? 查處情形_已處分文號 { get; set; }

    public string? 查處情形_其他備註 { get; set; }

    public DateTime? 查處情形_處分日期 { get; set; }

    public string? 查處情形_媒體提供託播業者資料 { get; set; }

    public string? 移查單位 { get; set; }

    public DateTime? 移查日期 { get; set; }

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 修改者帳號 { get; set; } = null!;

    public DateTime 修改時間 { get; set; }

    public string? 發文文號 { get; set; }

    public DateTime? 進行案件函詢_發文日期 { get; set; }

    public DateTime? 進行案件函詢_函詢完成日 { get; set; }

    public string? 結案文號 { get; set; }

    public string? 處分對象 { get; set; }

    public string? 廣告託播業者_檔案路徑 { get; set; }

    public string? 薦證代言人_檔案路徑 { get; set; }

    public string? 傳播媒體_檔案路徑 { get; set; }

    /// <summary>
    /// 代言人
    /// </summary>
    public string? 處分薦證代言人 { get; set; }

    public string? 處分託播業者_依食安法第四十五條廣告處理原則 { get; set; }

    public string? 處分託播業者_無依食安法第四十五條廣告處理原則 { get; set; }

    public string? 處分薦證代言人_依食安法第四十五條廣告處理原則 { get; set; }

    public string? 處分薦證代言人_無依食安法第四十五條廣告處理原則 { get; set; }

    public string? 處分傳播媒體_依食安法第四十五條廣告處理原則 { get; set; }

    public string? 處分傳播媒體_無依食安法第四十五條廣告處理原則 { get; set; }

    public string? 輔導結案_涉嫌違反法規 { get; set; }

    public string? 處分託播業者_傳直銷廠商 { get; set; }

    public string? 處分薦證代言人_傳直銷廠商 { get; set; }

    public string? 處分傳播媒體_傳直銷廠商 { get; set; }

    public string? 是否上傳食藥膨風廣告專區 { get; set; }

    public string? 進行案件函詢_受文者 { get; set; }

    public int? 進行案件函詢_調查或函詢天數 { get; set; }

    public string? 進行案件函詢_原因 { get; set; }

    public string? 處分託播業者_其他行政罰 { get; set; }

    public DateTime? 相關案件處分日期 { get; set; }
}
