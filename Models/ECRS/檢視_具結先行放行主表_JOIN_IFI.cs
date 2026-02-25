using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_具結先行放行主表_JOIN_IFI
{
    public int 主鍵 { get; set; }

    public DateTime? 資料寫入日期 { get; set; }

    public string? 報單號碼 { get; set; }

    public string? 報驗案號 { get; set; }

    public string? 報驗義務人中文名稱 { get; set; }

    public string? 報驗義務人英文名稱 { get; set; }

    public string? 牌名 { get; set; }

    public string? 受理日期 { get; set; }

    public string? 進口日期 { get; set; }

    public string? 放行日期 { get; set; }

    public string? 檢驗日期 { get; set; }

    public string? 檢驗結果代碼 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 一般案件申請事由 { get; set; }

    public string? 聯絡人 { get; set; }

    public string? 聯絡人EMAIL { get; set; }

    public string? 聯絡人電話 { get; set; }

    public string? 聯絡人傳真 { get; set; }

    public string? 聯絡人手機 { get; set; }

    public string? 備註 { get; set; }

    public string? 具結日期 { get; set; }

    public string? 起運日期 { get; set; }

    public string? 到貨日期 { get; set; }

    public string? 預定提貨日期 { get; set; }

    public string? 審查結果代碼 { get; set; }

    public string? 審查結果 { get; set; }

    public string? 異動人員PK { get; set; }

    public string? 異動日期 { get; set; }

    public string? 異動時間 { get; set; }

    public string? 刪除註記 { get; set; }

    public string? 報驗義務人統編 { get; set; }

    public string? 是否為中文標示補正 { get; set; }

    public string? 主提單號碼 { get; set; }

    public string? 刪除原因 { get; set; }

    public string? 案件承辦人員 { get; set; }

    public string? 案件承辦人員電話 { get; set; }

    public decimal? IFI系統主表PK { get; set; }

    public string? 報驗義務人營業登記地址 { get; set; }

    public string? 評定摘要 { get; set; }
}
