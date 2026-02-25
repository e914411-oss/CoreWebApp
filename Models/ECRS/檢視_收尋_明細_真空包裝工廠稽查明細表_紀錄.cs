using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_收尋_明細_真空包裝工廠稽查明細表_紀錄
{
    public DateTime? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? Signboard_Name { get; set; }

    public string? City_Name { get; set; }

    public string? County_Name { get; set; }

    public string? Business_Address { get; set; }

    public string? Responsible_Person_Name { get; set; }

    public string? ORG { get; set; }

    public string? Telephone { get; set; }

    public DateOnly? DAYLINEDATE { get; set; }

    public int? Industry_ID { get; set; }

    public string? ContractorsName { get; set; }

    public string? InspectorsName { get; set; }

    public DateTime? RECHK_Date { get; set; }

    public int Check_List_ID { get; set; }

    public string? Unit { get; set; }

    public string? Company_Name { get; set; }

    public string 結案狀態 { get; set; } = null!;

    public string 限期改善日期_國曆 { get; set; } = null!;

    public string 產品名稱 { get; set; } = null!;

    public string 產品特性 { get; set; } = null!;

    public string 產品特性_即食 { get; set; } = null!;

    public string 產品特性_非即食 { get; set; } = null!;

    public string 稽查結果 { get; set; } = null!;

    public string 應改善項目 { get; set; } = null!;

    public string 複查註記 { get; set; } = null!;

    public int 真空包裝工廠稽查主表主鍵 { get; set; }

    public int 前一次稽查主鍵 { get; set; }

    public string? Company_Tax_ID { get; set; }

    public string? Factory_Reg_ID { get; set; }

    public string 違反法條_食品安全衛生管理法第二十二條第一項第九款 { get; set; } = null!;

    public string 違反法條_食品安全衛生管理法第八條第一項 { get; set; } = null!;

    public string 處理情形_停業 { get; set; } = null!;

    public string 處理情形_移送法院 { get; set; } = null!;

    public int 處理情形_罰鍰金額 { get; set; }

    public string 備註 { get; set; } = null!;

    public string 稽查人員主鍵 { get; set; } = null!;

    public string 承辦人員主鍵 { get; set; } = null!;

    public string 審查人員主鍵 { get; set; } = null!;

    public string 作業階段 { get; set; } = null!;

    public DateTime? 結案日期_國曆 { get; set; }

    public string 水活性或pH值 { get; set; } = null!;

    public string 標示販售條件 { get; set; } = null!;

    public string 商業滅菌 { get; set; } = null!;

    public string 柵欄技術 { get; set; } = null!;

    public string 標示保存期限 { get; set; } = null!;

    public string 標示須冷藏或須冷凍 { get; set; } = null!;

    public string 字體長寬大於1CM { get; set; } = null!;

    public string 符合GHP { get; set; } = null!;

    public string 應改善項目_其他備註 { get; set; } = null!;

    public string? 修改原因 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public int 完成主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
