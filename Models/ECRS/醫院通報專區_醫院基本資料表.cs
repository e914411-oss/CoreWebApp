using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 醫院通報專區_醫院基本資料表
{
    /// <summary>
    /// 醫事機構代碼，例如 5X310XXXXX
    /// </summary>
    public string 醫事機構代碼 { get; set; } = null!;

    /// <summary>
    /// 醫療院所全名，例如 臺北市立聯合醫院(忠孝院區)
    /// </summary>
    public string 醫療院所名稱_全名 { get; set; } = null!;

    /// <summary>
    /// 醫療院所別名，例如 忠孝醫院
    /// </summary>
    public string? 醫療院所別名 { get; set; }

    /// <summary>
    /// 醫療院所院區名稱，例如 忠孝院區
    /// </summary>
    public string? 醫療院所院區名稱 { get; set; }

    /// <summary>
    /// 醫療院所所在縣市編號，關聯 PMDS.dbo.縣市代碼表
    /// </summary>
    public string 醫療院所所在縣市編號 { get; set; } = null!;

    /// <summary>
    /// 醫療院所所在縣市名稱，關聯 PMDS.dbo.縣市代碼表
    /// </summary>
    public string 醫療院所所在縣市名稱 { get; set; } = null!;

    /// <summary>
    /// 醫療院所所在地區編號，關聯 PMDS.dbo.鄉鎮代碼表
    /// </summary>
    public string 醫療院所所在地區編號 { get; set; } = null!;

    /// <summary>
    /// 醫療院所所在地區名稱，關聯 PMDS.dbo.鄉鎮代碼表
    /// </summary>
    public string 醫療院所所在地區名稱 { get; set; } = null!;

    /// <summary>
    /// 醫療院所地址街道，例如 大安路 1段 1號 2樓
    /// </summary>
    public string 醫療院所地址街道 { get; set; } = null!;

    /// <summary>
    /// 負責人姓名
    /// </summary>
    public string? 負責人姓名 { get; set; }

    /// <summary>
    /// 負責人性別
    /// </summary>
    public string? 負責人姓名性別 { get; set; }

    /// <summary>
    /// 負責人電話
    /// </summary>
    public string? 負責人電話 { get; set; }

    /// <summary>
    /// 負責人行動電話
    /// </summary>
    public string? 負責人_行動電話 { get; set; }

    /// <summary>
    /// 負責人電子郵件
    /// </summary>
    public string? 負責人_電子郵件 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime? 修改時間 { get; set; }

    public string? 是否刪除 { get; set; }
}
