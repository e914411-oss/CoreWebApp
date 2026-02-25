using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 醫療器材稽查明細表
{
    /// <summary>
    /// 醫療器材稽查序號
    /// </summary>
    public int 主鍵 { get; set; }

    public int? 醫療器材稽查主表主鍵 { get; set; }

    /// <summary>
    /// 稽查序號
    /// </summary>
    public int? 稽查事件主鍵 { get; set; }

    /// <summary>
    /// 稽查物品註記-抽驗稽查
    /// </summary>
    public string? 抽驗稽查 { get; set; }

    /// <summary>
    /// 稽查物品註記-標示稽查
    /// </summary>
    public string? 標示稽查 { get; set; }

    public string? 產品類別 { get; set; }

    /// <summary>
    /// 產品中文名稱
    /// </summary>
    public string? 產品中文名稱 { get; set; }

    public string? 產品編號 { get; set; }

    /// <summary>
    /// 許可證字號
    /// </summary>
    public string? 許可證字號 { get; set; }

    /// <summary>
    /// 製造日期
    /// </summary>
    public DateOnly? 製造日期 { get; set; }

    /// <summary>
    /// 有效期間
    /// </summary>
    public string? 有效期間 { get; set; }

    /// <summary>
    /// 保存期限
    /// </summary>
    public DateOnly? 保存期限 { get; set; }

    /// <summary>
    /// 批號
    /// </summary>
    public string? 批號 { get; set; }

    /// <summary>
    /// 申請商名稱
    /// </summary>
    public string? 申請商名稱 { get; set; }

    /// <summary>
    /// 申請商地址
    /// </summary>
    public string? 申請商地址 { get; set; }

    /// <summary>
    /// 製造商國別(國別代碼)
    /// </summary>
    public string? 製造商國別代碼 { get; set; }

    /// <summary>
    /// 製造商名稱
    /// </summary>
    public string? 製造商名稱 { get; set; }

    /// <summary>
    /// 製造商地址
    /// </summary>
    public string? 製造商地址 { get; set; }

    /// <summary>
    /// 稽查結果
    /// </summary>
    public string? 稽查結果是否合格 { get; set; }

    /// <summary>
    /// 標示稽查_不合格樣態
    /// </summary>
    public string? 標示_稽查不合格樣態 { get; set; }

    public string? 稽查結果 { get; set; }

    /// <summary>
    /// 抽查作業記錄
    /// </summary>
    public string? 抽查作業記錄 { get; set; }

    /// <summary>
    /// 稽查人員(抽驗)
    /// </summary>
    public string? 抽驗_稽查人員主鍵 { get; set; }

    /// <summary>
    /// 承辦人員(抽驗)
    /// </summary>
    public string? 抽驗_承辦人員主鍵 { get; set; }

    /// <summary>
    /// 審查人員(抽驗)
    /// </summary>
    public string? 抽驗_審查人員主鍵 { get; set; }

    /// <summary>
    /// 流程階段(抽驗)
    /// </summary>
    public string? 抽驗_作業階段 { get; set; }

    /// <summary>
    /// 結案狀態(抽驗)
    /// </summary>
    public string? 抽驗_結案狀態 { get; set; }

    /// <summary>
    /// 結案日期(抽驗)
    /// </summary>
    public DateOnly? 抽驗_結案日期 { get; set; }

    /// <summary>
    /// 稽查人員(標示)
    /// </summary>
    public string? 標示_稽查人員主鍵 { get; set; }

    /// <summary>
    /// 承辦人員(標示)
    /// </summary>
    public string? 標示_承辦人員主鍵 { get; set; }

    /// <summary>
    /// 審查人員(標示)
    /// </summary>
    public string? 標示_審查人員主鍵 { get; set; }

    /// <summary>
    /// 流程階段(標示)
    /// </summary>
    public string? 標示_作業階段 { get; set; }

    /// <summary>
    /// 結案狀態(標示)
    /// </summary>
    public string? 標示_結案狀態 { get; set; }

    /// <summary>
    /// 結案日期(標示)
    /// </summary>
    public DateOnly? 標示_結案日期 { get; set; }

    /// <summary>
    /// 新增時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 新增人員
    /// </summary>
    public string? 建立人員主鍵 { get; set; }

    /// <summary>
    /// 異動時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? 異動人員主鍵 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public string? 許可證代碼 { get; set; }

    public string? 抽驗_違規樣態 { get; set; }
}
