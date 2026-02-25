using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_化粧品業者稽查清單
{
    public string? 縣市代碼檔 { get; set; }

    public int 化粧品業者稽查主檔ID { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public string? 工作紀錄內容 { get; set; }

    public int? 稽查結果ID { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 限期改正日期 { get; set; }

    public string? 稽查人員 { get; set; }

    public string? 承辦人員 { get; set; }

    public string? 審查人員 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 結案狀態 { get; set; }

    public string? 結案日期 { get; set; }

    public string? 處分情形_行政處分 { get; set; }

    public string? 處分情形_停業 { get; set; }

    public DateOnly? 處分情形_停業期限 { get; set; }

    public string? 處分情形_歇業 { get; set; }

    public string? 處分情形_廢止其登記 { get; set; }

    public string? 處分情形_移送法辦 { get; set; }

    public string? 處分情形_其它 { get; set; }

    public string? 處分情形_其它原因 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public string? 前一次衛生局主鍵 { get; set; }

    public string? 最初衛生局主鍵 { get; set; }

    public int? 前一次業者稽查主檔ID { get; set; }

    public int? 第一次業者稽查主檔ID { get; set; }

    public string? 專案編號 { get; set; }

    public string? 專案名稱 { get; set; }

    public string? 市招名稱 { get; set; }

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

    public string? Rechk { get; set; }

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
}
