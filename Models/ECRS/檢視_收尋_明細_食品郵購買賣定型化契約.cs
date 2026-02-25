using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_收尋_明細_食品郵購買賣定型化契約
{
    public int ID { get; set; }

    public int 稽查序號 { get; set; }

    public string 有無使用定型化契約 { get; set; } = null!;

    public string 稽查結果 { get; set; } = null!;

    public string? 稽查結果_涵義 { get; set; }

    public int rid { get; set; }

    public string? 契約類型 { get; set; }

    public string? 專案ID { get; set; }

    public string? 專案名稱 { get; set; }

    public string? 買賣形式 { get; set; }

    public DateOnly? 限期改善日期 { get; set; }

    public decimal? 罰款金額 { get; set; }

    public string 稽查進度 { get; set; } = null!;

    public string 目前人員 { get; set; } = null!;

    public string 稽查員 { get; set; } = null!;

    public string 承辦員 { get; set; } = null!;

    public string 審查員 { get; set; } = null!;

    public string 是否結案 { get; set; } = null!;

    public DateTime? 結案日期 { get; set; }

    public int 上一次稽查序號 { get; set; }

    public int 複查筆數 { get; set; }

    public int 最初稽查序號 { get; set; }

    public string 備註 { get; set; } = null!;

    public DateTime 建立日期 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime 更新日期 { get; set; }

    public string? 更新人員 { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? Signboard_Name { get; set; }

    public string? Business_city_ID { get; set; }

    public string? City_Name { get; set; }

    public string? Business_County_ID { get; set; }

    public string? County_Name { get; set; }

    public string Business_Address { get; set; } = null!;

    public string? Telephone { get; set; }

    public string? Responsible_Person_Name { get; set; }

    public string? External_Key { get; set; }

    public string? Company_Tax_ID { get; set; }

    public string? Factory_Reg_ID { get; set; }

    public int? Industry_ID { get; set; }

    public string? Main_Name { get; set; }

    public string? Sub_Name { get; set; }

    public string? Sub_ID { get; set; }

    public string? Main_ID { get; set; }

    public string? External_Key_CL { get; set; }

    public string? 會同單位_檢 { get; set; }

    public string? 會同單位_警 { get; set; }

    public string? 會同單位_調 { get; set; }

    public string? 會同單位_食藥署 { get; set; }

    public string? 會同單位_其它 { get; set; }

    public string? 會同單位_其它單位名稱 { get; set; }

    public string? 稽查員名字 { get; set; }

    public string? 承辦員名字 { get; set; }

    public string? 審查員名字 { get; set; }
}
