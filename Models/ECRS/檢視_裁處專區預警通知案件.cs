using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_裁處專區預警通知案件
{
    public int 裁處系統主表編號 { get; set; }

    public string? 發文日期TW { get; set; }

    public DateOnly? 發文日期 { get; set; }

    public DateOnly? 罰鍰_裁處書送達日期 { get; set; }

    public int? 累計繳納金額 { get; set; }

    public int? 罰鍰_裁處金額 { get; set; }

    public DateOnly? 罰鍰_催繳日期 { get; set; }

    public string? 催繳日期TW { get; set; }

    public DateOnly? 罰鍰_催繳函送達日期 { get; set; }

    public string? 罰鍰_催繳文號 { get; set; }

    public string? 罰鍰_是否繳納 { get; set; }

    public string? 是否提出訴願 { get; set; }

    public DateOnly? 訴願受理日期 { get; set; }

    public DateOnly? 訴願決定日期 { get; set; }

    public string? 訴願結果 { get; set; }

    public string? 處分機關名稱 { get; set; }

    public string? 處分機關編號 { get; set; }

    public string? 處分機關科室代碼 { get; set; }

    public DateOnly? 發函國稅局日期 { get; set; }

    public DateOnly? 強制執行日期 { get; set; }

    public int? 強制執行金額 { get; set; }

    public string? 強制執行日期TW { get; set; }

    public DateOnly? 債權憑證日期 { get; set; }

    public string? 發文字號 { get; set; }

    public string 是否可結案 { get; set; } = null!;

    public string? 案件承辦人員 { get; set; }

    public string? 電子郵件 { get; set; }
}
