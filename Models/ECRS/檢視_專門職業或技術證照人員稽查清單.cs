using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_專門職業或技術證照人員稽查清單
{
    public int 主鍵 { get; set; }

    public string? 縣市代碼 { get; set; }

    public int 稽查事件主鍵 { get; set; }

    public string? 稽查結果代碼 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 現場稽查描述 { get; set; }

    public string? 承辦_備註說明 { get; set; }

    public string? 承辦意見 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 結案狀態 { get; set; }

    public string? 結案日期 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public string? 不適用原因_食品從業人員未滿20人 { get; set; }

    public string? 不適用原因_無工廠登記 { get; set; }

    public string? 不適用原因_資本額未達3千萬 { get; set; }

    public string? 不適用原因_非規範業別 { get; set; }

    public string? 登錄各該人員資料及衛生講習或訓練時數 { get; set; }

    public string? 聘用食品專職或技術證照人員 { get; set; }

    public string? 違反法條_食安第十二條 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 異動人員姓名 { get; set; }

    public string? 衛生局系統主鍵 { get; set; }

    public string 專案代號 { get; set; } = null!;

    public string 專案名稱 { get; set; } = null!;

    public string? 市招名稱 { get; set; }

    public string? 商業登記名稱 { get; set; }

    public string? Business_City_ID { get; set; }

    public string? Business_County_ID { get; set; }

    public string 縣市 { get; set; } = null!;

    public string 鄉鎮區 { get; set; } = null!;

    public string Business_Address { get; set; } = null!;

    public int? 業者編號 { get; set; }

    public string? 電話 { get; set; }

    public string? 負責人 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 工廠登記證號 { get; set; }

    public string? 業者主類編號 { get; set; }

    public string? 業者次類編號 { get; set; }

    public string? 業者主類名稱 { get; set; }

    public string? 業者次類名稱 { get; set; }

    public int 前一次稽查主鍵 { get; set; }

    public int 最初稽查主鍵 { get; set; }

    public string Rechk { get; set; } = null!;

    public string? 稽查人員ID { get; set; }

    public string? 稽查人員姓名 { get; set; }

    public string? 承辦人員ID { get; set; }

    public string? 承辦人員姓名 { get; set; }

    public string? 審查人員ID { get; set; }

    public string? 審查人員姓名 { get; set; }

    public string? 案件狀態 { get; set; }

    public string? 會同單位_檢 { get; set; }

    public string? 會同單位_警 { get; set; }

    public string? 會同單位_調 { get; set; }

    public string? 會同單位_食藥署 { get; set; }

    public string? 會同單位_其它 { get; set; }

    public string? 會同單位_其它單位名稱 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? 國曆限定完成日 { get; set; }

    public string? 國曆稽查日期 { get; set; }

    public string? 刪除註記 { get; set; }

    public string? 食品業者登錄字號 { get; set; }
}
