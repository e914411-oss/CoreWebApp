using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品核備資料查詢一
{
    public int 食品核備資料查詢一編號 { get; set; }

    public string? 食物核備統一編號 { get; set; }

    public string? 食物確認類型 { get; set; }

    public string? 中文名稱 { get; set; }

    public string? 英文名稱 { get; set; }

    public string? 建立日期 { get; set; }

    public string? 到期日期 { get; set; }

    public string? 英文公司名稱 { get; set; }

    public string? 公司中文名稱 { get; set; }

    public string? 電話號碼 { get; set; }

    public string? 食物包裝類型 { get; set; }

    public string? 狀態 { get; set; }

    public string? fcr編號 { get; set; }

    public string? fcs註冊編號 { get; set; }

    public string? fcmd的國家名稱 { get; set; }
}
