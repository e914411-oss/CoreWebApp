using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 衛生署審核通過之健康食品一覽表
{
    public int 流水編號 { get; set; }

    public int 種類 { get; set; }

    public string? 註冊編號 { get; set; }

    public string? 連結檔號檔名 { get; set; }

    public string? 中文名稱 { get; set; }

    public string? 英文名稱 { get; set; }

    public string? 基本配方 { get; set; }

    public string? 說明 { get; set; }

    public string? 一個單位含量的說明 { get; set; }

    public string? 確認時間 { get; set; }

    public string? 確認種類 { get; set; }

    public string? 種類說明 { get; set; }

    public string? 公司名稱 { get; set; }

    public string? 圖片連結 { get; set; }

    public string? 縣市 { get; set; }

    public string? 地址 { get; set; }

    public string? 電話 { get; set; }

    public string? 負責人 { get; set; }

    public string? 外觀的類型 { get; set; }

    public string? 真正的成分種類 { get; set; }

    public string? 製造廠名稱 { get; set; }

    public string? 製造廠地址 { get; set; }

    public string? 生產的國別 { get; set; }

    public string? 生產的國別說明 { get; set; }

    public string? 安全等級 { get; set; }

    public string? 安全等級說明 { get; set; }

    public string? 功效 { get; set; }

    public string? 效能測試的類型 { get; set; }

    public string? 分別部門 { get; set; }

    public string? 其他紀錄 { get; set; }

    public int? 控制 { get; set; }

    public string? 警語 { get; set; }

    public string? 公告 { get; set; }

    public string? 附件圖檔的說明 { get; set; }
}
