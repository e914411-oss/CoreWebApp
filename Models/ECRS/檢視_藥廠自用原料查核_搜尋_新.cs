using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_藥廠自用原料查核_搜尋_新
{
    public int 主鍵 { get; set; }

    public int? 稽查序號 { get; set; }

    public string? 查核結果_報關文件相符 { get; set; }

    public string? 查核結果_資訊相符 { get; set; }

    public int? 查核結果_實際進口量 { get; set; }

    public DateTime? 查核結果_進口時間 { get; set; }

    public string? 查核結果_原料原廠批號 { get; set; }

    public int? 查核結果_入庫數量 { get; set; }

    public DateTime? 查核結果_入庫時間 { get; set; }

    public int? 查核結果_原料剩餘數量 { get; set; }

    public string? 查核結果_入庫量相符 { get; set; }

    public string? 查核結果_入庫時間是否合理 { get; set; }

    public string? 查核結果_是否提出解釋及切結書 { get; set; }

    public DateOnly? 查核結果_處分時間 { get; set; }

    public string? 查核結果_缺失說明 { get; set; }

    public string? 查核結果_其他說明 { get; set; }

    public string? 處理情形_移外縣市 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public string? 處理情形_限期改善 { get; set; }

    public DateOnly? 處分情形_限期改善日期 { get; set; }

    public string? 處理情形_禁止出售 { get; set; }

    public string? 處理情形_其他 { get; set; }

    public string? 處理情形_其他說明 { get; set; }

    public string? 移外縣市_函送文號 { get; set; }

    public DateOnly? 移外縣市_函送日期 { get; set; }

    public string? 移外縣市主鍵 { get; set; }

    public string? 移外縣市_市招名稱 { get; set; }

    public string? 移外縣市_負責人 { get; set; }

    public string? 移外縣市_業者地址 { get; set; }

    public string? 移外縣市_移外原因 { get; set; }

    public string? 備註說明 { get; set; }

    public int? 專案名稱主鍵 { get; set; }

    public int? 專案明細主鍵 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 結案狀態 { get; set; }

    public string? 自用源料申請商 { get; set; }

    public DateTime? 發文日期 { get; set; }

    public string? 發文字號 { get; set; }

    public string? 原料藥製造廠國名 { get; set; }

    public string? 原料藥製造廠名稱 { get; set; }

    public string? 原料藥製造廠地址_縣市 { get; set; }

    public string? 原料藥製造廠地址_區域 { get; set; }

    public string? 原料藥製造廠地址_地址 { get; set; }

    public int? 季別 { get; set; }

    public int? 申請進口數量 { get; set; }

    public string? 供製造藥品之中文品名 { get; set; }

    public string? 供製造藥品之許可證字號 { get; set; }

    public string? 使用該原料藥之製造商名稱 { get; set; }

    public string? 原料藥品名稱 { get; set; }

    public int? Industry_ID { get; set; }

    public string? PJNO { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? CHKTime_ROC { get; set; }

    public string? Signboard_Name { get; set; }

    public string? Business_City_ID { get; set; }

    public string? Business_County_ID { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 會同單位_檢 { get; set; }

    public string? 會同單位_警 { get; set; }

    public string? 會同單位_調 { get; set; }

    public string? 會同單位_食藥署 { get; set; }

    public string? 會同單位_其它 { get; set; }

    public string? 會同單位_其它單位名稱 { get; set; }

    public string 稽查人員 { get; set; } = null!;

    public string 承辦人員 { get; set; } = null!;

    public string 審查人員 { get; set; } = null!;
}
