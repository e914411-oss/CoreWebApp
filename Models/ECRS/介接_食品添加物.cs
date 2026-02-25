using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 介接_食品添加物
{
    public string? 業者_名稱 { get; set; }

    public string? 業者_地址 { get; set; }

    public string? 業者_電話 { get; set; }

    public string? 業者_編號 { get; set; }

    public string? 業者_負責人 { get; set; }

    public string? 添加物_中文名稱 { get; set; }

    public string? 添加物_英文名稱 { get; set; }

    public string? 許可證字號 { get; set; }

    public string? 許可證字號_狀態 { get; set; }

    public DateOnly? 許可證字號_更新日期 { get; set; }

    public string? 添加物_型態1 { get; set; }

    public string? 添加物_型態1_名稱 { get; set; }

    public string? 添加物_型態2 { get; set; }

    public string? 添加物_型態2_名稱 { get; set; }

    public string? 添加物_型態3 { get; set; }

    public string? 添加物_型態3_名稱 { get; set; }

    public DateTime? 許可證字號_日期 { get; set; }

    public string? 添加物_國家 { get; set; }

    public string? 添加物_工廠 { get; set; }

    public string? 添加物_地址 { get; set; }

    public string? 國內製造廠工廠登記證號 { get; set; }

    public string? 國內製造廠_負責人 { get; set; }

    public string? 國內製造廠_電話 { get; set; }
}
