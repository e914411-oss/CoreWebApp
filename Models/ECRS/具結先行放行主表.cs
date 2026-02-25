using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 具結先行放行主表
{
    public int 主鍵 { get; set; }

    /// <summary>
    /// 資料日期
    /// </summary>
    public DateTime? 資料寫入日期 { get; set; }

    /// <summary>
    /// 報單號碼
    /// </summary>
    public string? 報單號碼 { get; set; }

    /// <summary>
    /// 報驗案號
    /// </summary>
    public string? 報驗案號 { get; set; }

    /// <summary>
    /// 報驗義務人名稱(中文)
    /// </summary>
    public string? 報驗義務人中文名稱 { get; set; }

    /// <summary>
    /// 報驗義務人(英文)
    /// </summary>
    public string? 報驗義務人英文名稱 { get; set; }

    /// <summary>
    /// 牌名
    /// </summary>
    public string? 牌名 { get; set; }

    /// <summary>
    /// 受理日期
    /// </summary>
    public string? 受理日期 { get; set; }

    /// <summary>
    /// 進口日期
    /// </summary>
    public string? 進口日期 { get; set; }

    /// <summary>
    /// 放行日期
    /// </summary>
    public string? 放行日期 { get; set; }

    /// <summary>
    /// 檢驗日期
    /// </summary>
    public string? 檢驗日期 { get; set; }

    /// <summary>
    /// 檢驗結果_代碼
    /// </summary>
    public string? 檢驗結果代碼 { get; set; }

    /// <summary>
    /// 檢驗結果_名稱
    /// </summary>
    public string? 檢驗結果 { get; set; }

    /// <summary>
    /// 一般案件申請事由
    /// </summary>
    public string? 一般案件申請事由 { get; set; }

    /// <summary>
    /// 聯絡人
    /// </summary>
    public string? 聯絡人 { get; set; }

    /// <summary>
    /// 聯絡人Email
    /// </summary>
    public string? 聯絡人EMAIL { get; set; }

    /// <summary>
    /// 聯絡電話
    /// </summary>
    public string? 聯絡人電話 { get; set; }

    /// <summary>
    /// 聯絡傳真
    /// </summary>
    public string? 聯絡人傳真 { get; set; }

    /// <summary>
    /// 聯絡人手機
    /// </summary>
    public string? 聯絡人手機 { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? 備註 { get; set; }

    /// <summary>
    /// 具結日期
    /// </summary>
    public string? 具結日期 { get; set; }

    /// <summary>
    /// 起運日期
    /// </summary>
    public string? 起運日期 { get; set; }

    /// <summary>
    /// 到貨日期
    /// </summary>
    public string? 到貨日期 { get; set; }

    /// <summary>
    /// 預定提貨日期
    /// </summary>
    public string? 預定提貨日期 { get; set; }

    /// <summary>
    /// 審查結果_代碼
    /// </summary>
    public string? 審查結果代碼 { get; set; }

    /// <summary>
    /// 審查結果_名稱
    /// </summary>
    public string? 審查結果 { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? 異動人員PK { get; set; }

    /// <summary>
    /// 異動日期
    /// </summary>
    public string? 異動日期 { get; set; }

    /// <summary>
    /// 異動時間
    /// </summary>
    public string? 異動時間 { get; set; }

    public string? 刪除註記 { get; set; }

    public string? 報驗義務人統編 { get; set; }

    public string? 是否為中文標示補正 { get; set; }

    public string? 主提單號碼 { get; set; }

    public string? 刪除原因 { get; set; }

    public string? 預定完成日期 { get; set; }

    public string? 食藥署已稽查 { get; set; }

    public string? 需封存 { get; set; }

    public string? 退運銷毀經食藥署審核可改製或採取適當安全措施 { get; set; }

    public string? 複驗完成日期 { get; set; }

    public string? 複驗查驗結果 { get; set; }

    public string? 複驗查驗結果說明 { get; set; }

    public string? 案件承辦人員 { get; set; }

    public string? 案件承辦人員電話 { get; set; }

    public decimal? IFI系統主表PK { get; set; }

    public string? 報驗義務人營業登記地 { get; set; }

    public string? 評定摘要 { get; set; }
}
