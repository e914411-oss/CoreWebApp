using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_邊境抽驗不合格後市場回報_搜尋清單
{
    public int 主案主鍵 { get; set; }

    public string 案件階層 { get; set; } = null!;

    public string? 縣市代碼 { get; set; }

    public string? 查驗對象地址 { get; set; }

    public string? 查驗對象業者名稱 { get; set; }

    public decimal 名單序號 { get; set; }

    public string 名單名稱 { get; set; } = null!;

    public decimal 案件序號 { get; set; }

    public string? 受理日期 { get; set; }

    public string 報驗案號 { get; set; } = null!;

    public string? 實際稽查業者統編 { get; set; }

    public string? 實際稽查業者名稱 { get; set; }

    public string? 實際稽查業者地址 { get; set; }

    public string? 貨品分類號列 { get; set; }

    public string? 產品中文名稱 { get; set; }

    public string? 生產國別代碼 { get; set; }

    public string? 生產國別 { get; set; }

    public string? 製造廠名稱 { get; set; }

    public decimal? 淨重 { get; set; }

    public string? 中文評定摘要 { get; set; }

    public string? 檢驗方式 { get; set; }

    public string? 結案日期 { get; set; }

    public int? 備註1 { get; set; }

    public int? 備註2 { get; set; }

    public string? IFI提供主案日期 { get; set; }

    public DateTime? 資料轉入日期 { get; set; }

    public int? 派案來源主案主鍵 { get; set; }

    public string 主案_報驗案號 { get; set; } = null!;

    public string? 稽查結果代碼 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 稽查結果_併前案_報驗案號 { get; set; }

    public string? 稽查結果_衛生局檢驗不合格_報驗案號 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 稽查日期_時 { get; set; }

    public string? 稽查日期_分 { get; set; }

    public string? 稽查日期_國曆 { get; set; }

    public string? 異動人員編號 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 刪除註記 { get; set; }

    public string? 刪除原因 { get; set; }

    public string? 備註 { get; set; }

    public string? 同批號產品 { get; set; }

    public string 稽查狀態 { get; set; } = null!;

    public string? 國曆轉入日期 { get; set; }

    public DateTime? 回報日期 { get; set; }
}
