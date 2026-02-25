using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_問題產品下架下游案件_FOR_FADEN
{
    public string 案件編號 { get; set; } = null!;

    public string? 上下游商稽查表_來源資料表 { get; set; }

    public int? 上下游商稽查表_來源主鍵 { get; set; }

    public int PMDS主鍵 { get; set; }

    public string? 上下游商稽查表_產品主鍵 { get; set; }

    public int? 上下游商稽查表_層數 { get; set; }

    public string? 派案衛生局_縣市 { get; set; }

    public string? 此階層_派案狀態 { get; set; }

    public decimal? 業者回報_製造量_進貨量 { get; set; }

    public decimal? 業者回報_售出量 { get; set; }

    public decimal? 業者回報_庫存量 { get; set; }

    public decimal? 業者回報_退回上游量 { get; set; }

    public decimal? 業者回報_下游退回量 { get; set; }

    public decimal? 業者回報_封存量 { get; set; }

    public decimal? 業者回報_其他 { get; set; }

    public string? 業者回報_備註 { get; set; }

    public DateTime? 業者回報_回報時間 { get; set; }

    public string 派案是否註銷 { get; set; } = null!;

    public string? 派案註銷原因 { get; set; }

    public DateTime? 派案註銷時間 { get; set; }

    public string? 派案是否結案 { get; set; }

    public DateTime? 派案結案日期 { get; set; }

    public string? 派案建立人員 { get; set; }

    public DateTime? 派案案件建立時間 { get; set; }

    public string? 派案修改人員 { get; set; }

    public DateTime? 派案案件異動時間 { get; set; }

    public int 母案_主鍵 { get; set; }

    public string? 母案_案件狀態 { get; set; }

    public string? 母案_是否派案至非登 { get; set; }

    public string? 母案_派案縣市 { get; set; }

    public string? 母案_協辦單位縣市代碼 { get; set; }

    public string? 母案_協辦單位 { get; set; }

    public string? 母案_下架回收原因 { get; set; }

    public string? 母案_違反法條 { get; set; }

    public DateTime? 母案_派案日期 { get; set; }

    public string? 母案_是否結案 { get; set; }

    public DateTime? 母案_結案日期 { get; set; }

    public DateTime? 母案_建立時間 { get; set; }

    public DateTime? 母案_異動時間 { get; set; }

    public int? 業者_主鍵 { get; set; }

    public int? 業者_來源主鍵 { get; set; }

    public int? 業者_上一層業者主鍵 { get; set; }

    public int? 業者_層數 { get; set; }

    public string? 業者_派案狀態 { get; set; }

    public string? 業者_是否派案至非登 { get; set; }

    public int? 業者_通知下游業者回收日期 { get; set; }

    public int? 業者_業者代碼 { get; set; }

    public int? 業者_業者序號 { get; set; }

    public string? 業者_業者名稱 { get; set; }

    public string? 業者_業者統一編號 { get; set; }

    public string? 業者_食品登錄字號 { get; set; }

    public string? 業者_業者縣市代碼 { get; set; }

    public string? 業者_業者鄉鎮代碼 { get; set; }

    public string? 業者_業者街道 { get; set; }

    public string? 業者_業者地址 { get; set; }

    public DateTime? 業者_出貨日期 { get; set; }

    public decimal? 業者_售出下游量 { get; set; }

    public decimal? 業者_下游退回量 { get; set; }

    public string? 業者_關聯多產品主鍵 { get; set; }

    public string? 業者_備註 { get; set; }

    public DateTime? 業者_建立日期 { get; set; }

    public DateTime? 業者_修改日期 { get; set; }

    public string? 業者_是否註銷 { get; set; }

    public string? 業者_註銷原因 { get; set; }

    public DateTime? 業者_註銷時間 { get; set; }

    public int? 販售產品_關聯多產品主鍵 { get; set; }

    public int? 販售產品_層數 { get; set; }

    public string? 販售產品_產品名稱 { get; set; }

    public string? 販售產品_產品規格 { get; set; }

    public int? 販售產品_產品屬性 { get; set; }

    public DateTime? 販售產品_有效日期 { get; set; }

    public string? 販售產品_產品批號 { get; set; }

    public decimal? 販售產品_製造量_進貨量 { get; set; }

    public decimal? 販售產品_售出量 { get; set; }

    public decimal? 販售產品_庫存量 { get; set; }

    public decimal? 販售產品_下游退回量 { get; set; }

    public decimal? 販售產品_封存量 { get; set; }

    public decimal? 販售產品_其他 { get; set; }

    public string? 販售產品_備註 { get; set; }

    public DateTime? 販售產品_建立日期 { get; set; }

    public DateTime? 販售產品_修改日期 { get; set; }
}
