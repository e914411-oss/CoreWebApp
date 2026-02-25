using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_邊境抽驗不合格後市場回報_查察回報案件清單
{
    public string 是否同批 { get; set; } = null!;

    public string 是否於時效內回報 { get; set; } = null!;

    public int? 最終辦理日數 { get; set; }

    public int? L2最終辦理日數 { get; set; }

    public string? 同批號產品 { get; set; }

    public string 案件階層 { get; set; } = null!;

    public string? 縣市代碼 { get; set; }

    public string? 報驗義務人 { get; set; }

    public DateTime? 資料轉入日期 { get; set; }

    public string? 資料轉入日期_國曆 { get; set; }

    public string 報驗案號 { get; set; } = null!;

    public string? 產品名稱 { get; set; }

    public DateTime? 回報日期 { get; set; }

    public string? 回報日期_國曆 { get; set; }

    public DateTime? 查核日期 { get; set; }

    public string? 查核日期_國曆 { get; set; }

    public string? 查核結果 { get; set; }

    public int? 辦理日數 { get; set; }

    public DateTime? 上傳附件日期 { get; set; }

    public string? 上傳附件日期_國曆 { get; set; }

    public DateTime? 報告日期 { get; set; }

    public string? 報告日期_國曆 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 備註 { get; set; }

    public string? 中文評定摘要 { get; set; }

    public string L2案件階層 { get; set; } = null!;

    public string? L2縣市代碼 { get; set; }

    public string? L2下游業者 { get; set; }

    public DateTime? L2派案通知日期 { get; set; }

    public string? L2派案通知日期_國曆 { get; set; }

    public DateTime? L2回報日期 { get; set; }

    public string? L2回報日期_國曆 { get; set; }

    public DateTime? L2查核日期 { get; set; }

    public string? L2查核日期_國曆 { get; set; }

    public string? L2查核結果 { get; set; }

    public int? L2辦理日數 { get; set; }

    public DateTime? L2上傳附件日期 { get; set; }

    public string? L2上傳附件日期_國曆 { get; set; }

    public DateTime? L2報告日期 { get; set; }

    public string? L2報告日期_國曆 { get; set; }

    public string? L2檢驗結果 { get; set; }

    public string? L2備註 { get; set; }

    public int 主案主鍵 { get; set; }
}
