using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_食品添加物許可證資料
{
    public int 食品添加物許可證資料主鍵 { get; set; }

    public string? 食品統一編號 { get; set; }

    public string? 衛生署核准冠字 { get; set; }

    public string? 核可編號 { get; set; }

    public string? 衛生署核准冠字核可編號 { get; set; }

    public string? 中文名稱 { get; set; }

    public string? 英文名稱 { get; set; }

    public string? 食品添加物狀態 { get; set; }

    public string? 添加劑型1 { get; set; }

    public string? 添加劑型2 { get; set; }

    public string? 添加公司名稱 { get; set; }

    public string? 公司電話 { get; set; }

    public string? 公司中文名稱 { get; set; }

    public string? 核可時間 { get; set; }

    public string? 到期時間 { get; set; }

    public string? 核可時間_索引 { get; set; }

    public string? 到期時間_索引 { get; set; }

    public string? 核可時間_國曆 { get; set; }

    public string? 到期時間_國曆 { get; set; }

    public string? 狀態 { get; set; }

    public string? FAS編號 { get; set; }

    public string? 國家 { get; set; }

    public string? 成份 { get; set; }

    public int 索引主鍵 { get; set; }

    public string? 索引名稱 { get; set; }
}
