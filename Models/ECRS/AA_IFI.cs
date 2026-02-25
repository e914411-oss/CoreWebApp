using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class AA_IFI
{
    public string 申請書號碼 { get; set; } = null!;

    public string? 受理日期 { get; set; }

    public string? 報驗義務人統一編號 { get; set; }

    public string? 報驗義務人名稱 { get; set; }

    public string? 報單號碼及項次 { get; set; }

    public string? 貨品分類號列 { get; set; }

    public string? 品名_中 { get; set; }

    public string? 生產國別 { get; set; }

    public string? 查驗方式 { get; set; }

    public string? 中分類 { get; set; }

    public string? 商標 { get; set; }

    public string? 規格 { get; set; }

    public string? 製造廠名稱 { get; set; }

    public string? 製造廠代號 { get; set; }

    public string? 製造批號 { get; set; }

    public string? 製造日期 { get; set; }

    public string? 有效日期 { get; set; }

    public string? 數量 { get; set; }

    public string? 淨重 { get; set; }

    public string? 查驗結果 { get; set; }

    public string? 評定摘要 { get; set; }

    public string? 是否申報輸入後供改裝分類或其他加工程序 { get; set; }

    public string? 備註 { get; set; }
}
