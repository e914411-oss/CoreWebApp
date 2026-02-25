using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 業者資料表_20250221
{
    public int 主鍵 { get; set; }

    public string? FMS介接主鍵 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 商業登記名稱 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 商業登記證號 { get; set; }

    public string? 工廠登記證號 { get; set; }

    public string? 營業地址_縣市主鍵 { get; set; }

    public string? 營業地址_鄉鎮區主鍵 { get; set; }

    public string? 營業地址_街道 { get; set; }

    public string? 營登地址_縣市主鍵 { get; set; }

    public string? 營登地址_鄉鎮區主鍵 { get; set; }

    public string? 營登地址街道 { get; set; }

    public string? 電話 { get; set; }

    public string? 傳真 { get; set; }

    public string? 營業狀態 { get; set; }

    public string? 辦理廚證人數 { get; set; }

    public string? 丙級烹飪證照 { get; set; }

    public string? 乙級烹飪證照 { get; set; }

    public string? 從業人數 { get; set; }

    public string? 證照HACCP { get; set; }

    public string? 證照GMP { get; set; }

    public string? 證照GSP { get; set; }

    public string? 證照CAS { get; set; }

    public string? 其他 { get; set; }

    public string? 負責人姓名 { get; set; }

    public string? 負責人手機號碼 { get; set; }

    public string? 負責人電子郵件 { get; set; }

    public string? 戶籍地址_縣市主鍵 { get; set; }

    public string? 戶籍地址_鄉鎮區主鍵 { get; set; }

    public string? 戶籍地址_街道 { get; set; }

    public string? 通訊地址_縣市主鍵 { get; set; }

    public string? 通訊地址_鄉鎮區主鍵 { get; set; }

    public string? 通訊地址街道 { get; set; }

    public string? 食品衛生管理員 { get; set; }

    public string? 食品衛生負責人 { get; set; }

    public string? 備註 { get; set; }

    public string? 水源別主鍵 { get; set; }

    public string? 水源別縣市主鍵 { get; set; }

    public string? 水源別鄉鎮區主鍵 { get; set; }

    public string? 水源別地址 { get; set; }

    public string? 水源產品名稱 { get; set; }

    public DateTime? 水源有效日期 { get; set; }

    public string? 國曆水源有效日期 { get; set; }

    public string? 異動人員 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public DateTime? 建檔時間 { get; set; }

    public string? 國曆建檔時間 { get; set; }

    public string? 建檔人員主鍵 { get; set; }

    public string? 建檔所屬縣市主鍵 { get; set; }

    public string? 建檔縣市主鍵 { get; set; }

    public DateTime? 資料傳送時間 { get; set; }

    public int? 資料狀態 { get; set; }

    public string? 最近稽查日期 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 刪除註記 { get; set; }

    public string? 業者產業平台登入標記 { get; set; }

    public string? 是否為HACCP { get; set; }

    public string? 是否為IRF { get; set; }

    public string? 食品技師姓名 { get; set; }

    public string? 技師證號 { get; set; }

    public string? 衛生管理人員 { get; set; }

    public string? 衛生專職人員 { get; set; }

    public string? 營養師 { get; set; }

    public string? 是否為健康食品工廠業者 { get; set; }

    public string? 是否為健康食品工廠業者_刪除 { get; set; }

    public string? HACCP業者主鍵 { get; set; }

    public string? 最大安全生產 { get; set; }

    public string? 營業狀態不確定 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 廚師人數 { get; set; }

    public string? 食品業者登錄字號 { get; set; }

    public string? 負責人身分證字號 { get; set; }

    public DateTime? 最近GHP稽查日期 { get; set; }

    public string? 刪除人員主鍵 { get; set; }

    public DateTime? 刪除時間 { get; set; }

    public string? 是否為自行新增 { get; set; }

    public bool? 是否已確認 { get; set; }

    public string? 醫療機構代碼 { get; set; }

    public string? 資料轉入來源PMDS { get; set; }

    public string? 藥事機構代碼 { get; set; }

    public string? 資料轉入來源 { get; set; }

    public string? 自行新增原因_內容 { get; set; }

    public string? 業者審核_狀態 { get; set; }

    public string? 業者審核_人員 { get; set; }

    public DateTime? 業者審核_通過日期 { get; set; }

    public string? 非登匯入業別 { get; set; }

    public string? 非登系統登錄情形 { get; set; }

    public string? 緊急聯絡人名稱 { get; set; }

    public string? 緊急聯絡人電子郵件 { get; set; }

    public string? 緊急聯絡人手機 { get; set; }

    public string? 是否自移外新增 { get; set; }
}
