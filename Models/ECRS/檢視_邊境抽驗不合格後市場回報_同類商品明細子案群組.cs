using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_邊境抽驗不合格後市場回報_同類商品明細子案群組
{
    public int 主鍵 { get; set; }

    public decimal 案件序號 { get; set; }

    public decimal 案件明細序號 { get; set; }

    public string 報驗案號 { get; set; } = null!;

    public string? 報單號碼 { get; set; }

    public decimal 報單項次 { get; set; }

    public string? 進口日期 { get; set; }

    public string? 申請人統編 { get; set; }

    public string? 申請人中文名稱 { get; set; }

    public string? 檢驗方式 { get; set; }

    public string? 產品中文名稱 { get; set; }

    public string? 產品英文名稱 { get; set; }

    public string? 生產國別代碼 { get; set; }

    public string? 生產國別 { get; set; }

    public string? 製造廠名稱 { get; set; }

    public string? 規格 { get; set; }

    public string? 製造日期 { get; set; }

    public string? 製造批號 { get; set; }

    public string? 有效日期 { get; set; }

    public decimal 數量 { get; set; }

    public string? 數量單位 { get; set; }

    public decimal? 淨重 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 結案日期 { get; set; }

    public string? 中文評定摘要 { get; set; }

    public string? 查驗項目 { get; set; }

    public DateTime? 資料轉入日期 { get; set; }

    public string? 相同產品 { get; set; }

    public string? 公司地址 { get; set; }

    public string? 公司電話 { get; set; }

    public string? 衛生局已查閱 { get; set; }

    public string? 初次已讀人員 { get; set; }

    public DateTime? 初次已讀時間 { get; set; }
}
