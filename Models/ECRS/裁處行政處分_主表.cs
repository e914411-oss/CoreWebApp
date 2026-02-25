using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處行政處分_主表
{
    public int 主鍵 { get; set; }

    public int 裁處系統主表編號 { get; set; }

    public int 行政處分類別 { get; set; }

    public DateOnly? 發文日期 { get; set; }

    public int? 發文字號_類型 { get; set; }

    public string? 發文字號_字 { get; set; }

    public string? 發文字號_號 { get; set; }

    public string? 主旨 { get; set; }

    public string? 受處分人姓名 { get; set; }

    public string? 受處分人統一編號 { get; set; }

    public string? 負責人 { get; set; }

    public string? 負責人身份證統一編號 { get; set; }

    public DateOnly? 負責人出生日期 { get; set; }

    public string? 負責人性別 { get; set; }

    public string? 受處分人地址 { get; set; }

    public string? 裁處書送達地區 { get; set; }

    public int? 罰鍰_裁處金額 { get; set; }

    public string? 罰鍰_低於應裁處金額之原因 { get; set; }

    public string? 罰鍰_是否違反具結先行放行 { get; set; }

    public string? 罰鍰_違反具結先行放行案件編號 { get; set; }

    public string? 罰鍰_是否繳納 { get; set; }

    public DateOnly? 罰鍰_裁處書送達日期 { get; set; }

    public string? 罰鍰_是否分期 { get; set; }

    public int? 罰鍰_分期總數 { get; set; }

    public DateOnly? 罰鍰_催繳日期 { get; set; }

    public DateOnly? 罰鍰_催繳函送達日期 { get; set; }

    public string? 罰鍰_催繳文號 { get; set; }

    public string? 具結_違規報驗案件 { get; set; }

    public string? 具結停權項目_擅自移動 { get; set; }

    public string? 具結停權項目_擅自啟用 { get; set; }

    public string? 具結停權項目_擅自擅自販賣者 { get; set; }

    public string? 具結停權項目_具結保管之存放地點與實際不符者 { get; set; }

    public string? 具結_有無法收保證金 { get; set; }

    public int? 具結_法收保證金金額 { get; set; }

    public DateTime? 具結_停止具結先行放行日期 { get; set; }

    public DateTime? 具結_恢復具結先行放行日期 { get; set; }

    public string? 撤銷許可證_申請書號碼 { get; set; }

    public string? 撤銷許可證_銷毀產品數量 { get; set; }

    public int? 行政指導_引用法條 { get; set; }

    public string? 行政指導_引用法條其他說明 { get; set; }

    public int? 行政指導_物品處置 { get; set; }

    public string? 行政指導_物品處置其他說明 { get; set; }

    public int? 累計繳納金額 { get; set; }

    public string? 是否提出訴願 { get; set; }

    public DateOnly? 訴願受理日期 { get; set; }

    public DateOnly? 訴願決定日期 { get; set; }

    public string? 訴願受理機關 { get; set; }

    public string? 訴願決定書文號 { get; set; }

    public string? 訴願結果 { get; set; }

    public string? 訴願結果_其他 { get; set; }

    public int? 另為適法之裁處編號 { get; set; }

    public string? 是否提出訴訟 { get; set; }

    public string? 衛生局主鍵 { get; set; }
}
