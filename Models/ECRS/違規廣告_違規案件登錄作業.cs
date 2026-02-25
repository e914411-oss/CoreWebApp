using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_違規案件登錄作業
{
    public string 違規案件編號 { get; set; } = null!;

    public string 媒體類型 { get; set; } = null!;

    public int 案件進度 { get; set; }

    public string? 併案主案件編號 { get; set; }

    public string? 併罰主案件編號 { get; set; }

    public string 案件來源機關 { get; set; } = null!;

    public string? 機關收文號 { get; set; }

    public DateTime 監控日期 { get; set; }

    public string 產品名稱 { get; set; } = null!;

    public string 產品類別 { get; set; } = null!;

    public string 違規類型 { get; set; } = null!;

    public string? 違規類型內容 { get; set; }

    public string? 電台名稱 { get; set; }

    public string? 節目名稱 { get; set; }

    public string? 電台頻道 { get; set; }

    public string? 電台頻率 { get; set; }

    public string? 電台主持人 { get; set; }

    public string? 主持人時間點_時 { get; set; }

    public string? 主持人時間點_分 { get; set; }

    public string? 產品時間點_時 { get; set; }

    public string? 產品時間點_分 { get; set; }

    public string? 購買電話時間點_時 { get; set; }

    public string? 購買電話時間點_分 { get; set; }

    public string? 購買地址時間點_時 { get; set; }

    public string? 購買地址時間點_分 { get; set; }

    public string? 違規時間 { get; set; }

    public string? 系統業者 { get; set; }

    public string? 廣告類型 { get; set; }

    public string? 電視節目頻道 { get; set; }

    public string? 電視頻道名稱 { get; set; }

    public string? 電視刊播時間_起_時 { get; set; }

    public string? 電視刊播時間_起_分 { get; set; }

    public string? 電視刊播時間_起_秒 { get; set; }

    public string? 電視刊播時間_迄_時 { get; set; }

    public string? 電視刊播時間_迄_分 { get; set; }

    public string? 電視刊播時間_迄_秒 { get; set; }

    public string? 電視廣告長度 { get; set; }

    public string? 電視節目名稱 { get; set; }

    public string? 電視主持人 { get; set; }

    public string? 見證代言人 { get; set; }

    public string? 媒體名稱 { get; set; }

    public DateTime? 出刊日期 { get; set; }

    public string? 出刊縣市 { get; set; }

    public string? 版面頁碼_版 { get; set; }

    public string? 版面頁碼_期 { get; set; }

    public string? 版面頁碼_頁 { get; set; }

    public string? 媒體地址 { get; set; }

    public string? 媒體電話 { get; set; }

    public string? 廣告核准字號 { get; set; }

    public string? 來源 { get; set; }

    public string? 訂購_公司 { get; set; }

    public string? 訂購_電話 { get; set; }

    public string? 訂購_地址 { get; set; }

    public string? 訂購_網址 { get; set; }

    public string? 訂購_信箱 { get; set; }

    public string? 網站名稱 { get; set; }

    public string? 所屬入口網站 { get; set; }

    public string? 網址 { get; set; }

    public string? 訂購方式 { get; set; }

    public string? 電台刊播時間_起_時 { get; set; }

    public string? 電台刊播時間_起_分 { get; set; }

    public string? 電台刊播時間_起_秒 { get; set; }

    public string? 電台刊播時間_迄_時 { get; set; }

    public string? 電台刊播時間_迄_分 { get; set; }

    public string? 電台刊播時間_迄_秒 { get; set; }

    public string? 購買電話 { get; set; }

    public string? 購買地址 { get; set; }

    public string? 多媒體檔案路徑 { get; set; }

    public DateTime? 交查日期 { get; set; }

    public string? 交查單位 { get; set; }

    public string? 附註 { get; set; }

    public string? 廣告內容 { get; set; }

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 修改者帳號 { get; set; } = null!;

    public DateTime 修改時間 { get; set; }

    public string? 平面媒體類型 { get; set; }

    public string? 傳輸文件數 { get; set; }

    public string? 紀錄電視的ID { get; set; }

    public string? 電台位置 { get; set; }

    public string? 電台名稱出現時間點_時 { get; set; }

    public string? 電台名稱出現時間點_分 { get; set; }

    public string? 電台地址出現時間點_時 { get; set; }

    public string? 電台地址出現時間點_分 { get; set; }

    public string? 電台電話出現時間點_時 { get; set; }

    public string? 電台電話出現時間點_分 { get; set; }

    public string? 電台頻道出現時間點_時 { get; set; }

    public string? 電台頻道出現時間點_分 { get; set; }

    public string? 節目名稱出現時間點_時 { get; set; }

    public string? 節目名稱出現時間點_分 { get; set; }

    public string? 媒體取得方法 { get; set; }

    public string? 媒體取得位置 { get; set; }

    public string? 紀錄承辦人ID { get; set; }

    public string? 紀錄其它說明 { get; set; }

    public string? 查詢報表說明 { get; set; }

    public string? 來文日期 { get; set; }

    public string? 來文字號 { get; set; }

    public string? 創號日期 { get; set; }

    public string? 處理數量 { get; set; }

    public string? 頻道 { get; set; }

    public string? 發文字號 { get; set; }

    public DateTime? 發文日期 { get; set; }

    public string? 建立機關 { get; set; }

    public DateTime? 收件日期日期格式 { get; set; }

    public int ICD主類編號 { get; set; }

    public int ICD次類編號 { get; set; }

    public DateTime? 查詢刊播業者日期 { get; set; }

    public DateTime? 刊播業者回覆日期 { get; set; }

    public DateTime? 查詢電信業者日期 { get; set; }
}
