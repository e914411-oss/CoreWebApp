using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品稽查明細表
{
    /// <summary>
    /// 化粧品稽查序號
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 化粧品稽查主檔ID 
    /// </summary>
    public int? 化粧品稽查主表主鍵 { get; set; }

    /// <summary>
    /// 稽查產品註記-抽驗稽查
    /// </summary>
    public string? 抽驗稽查 { get; set; }

    /// <summary>
    /// 稽查產品註記-標示稽查
    /// </summary>
    public string? 標示稽查 { get; set; }

    /// <summary>
    /// 產品類別
    /// </summary>
    public string? 產品類別 { get; set; }

    /// <summary>
    /// 產品品名
    /// </summary>
    public string? 產品品名 { get; set; }

    public string? 產品編號 { get; set; }

    public int? 品項類別 { get; set; }

    public string? 品項類別其他_明細 { get; set; }

    /// <summary>
    /// 產品許可證字號
    /// </summary>
    public string? 產品許可證字號 { get; set; }

    public string? 案件來源 { get; set; }

    public string? 案件來源其他 { get; set; }

    /// <summary>
    /// 物品重量
    /// </summary>
    public int? 物品重量 { get; set; }

    /// <summary>
    /// 物品重量單位
    /// </summary>
    public string? 物品重量單位 { get; set; }

    /// <summary>
    /// 保存期限
    /// </summary>
    public DateOnly? 保存期限 { get; set; }

    /// <summary>
    /// 產品抽驗-製造日期
    /// </summary>
    public DateOnly? 產品抽驗_製造日期 { get; set; }

    /// <summary>
    /// 批號
    /// </summary>
    public string? 批號 { get; set; }

    /// <summary>
    /// 來源商名稱
    /// </summary>
    public string? 來源商名稱 { get; set; }

    /// <summary>
    /// 來源商地址
    /// </summary>
    public string? 來源商地址 { get; set; }

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
    public string? 製造商國別 { get; set; }

    /// <summary>
    /// 製造商名稱
    /// </summary>
    public string? 製造商名稱 { get; set; }

    /// <summary>
    /// 製造商地址
    /// </summary>
    public string? 製造商地址 { get; set; }

    /// <summary>
    /// 標示稽查_不合格樣態
    /// </summary>
    public string? 標示_稽查不合格樣態 { get; set; }

    public string? 標示_稽查結果 { get; set; }

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

    public string? 備註 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public string? 許可證代碼 { get; set; }

    public string? 國產或輸入 { get; set; }

    public string? 製造商國別代碼 { get; set; }

    public string? 抽驗_違規樣態 { get; set; }

    public string? 抽驗_違規樣態_其他內容 { get; set; }

    public int? 品項次類別編號 { get; set; }

    public string? 化粧品產品登錄編號 { get; set; }

    public string? 產品登錄稽查 { get; set; }

    public string? 產品資訊檔案稽查 { get; set; }

    public string? 產品登錄_未完成登錄 { get; set; }

    public string? 產品登錄_不符合規定 { get; set; }

    public string? 產品登錄_稽查人員主鍵 { get; set; }

    public string? 產品登錄_承辦人員主鍵 { get; set; }

    public string? 產品登錄_審查人員主鍵 { get; set; }

    public string? 產品登錄_作業階段 { get; set; }

    public string? 產品登錄_結案狀態 { get; set; }

    public DateOnly? 產品登錄_結案日期 { get; set; }

    public string? 產品資訊檔案_未建立 { get; set; }

    public string? 產品資訊檔案_建立不符規定 { get; set; }

    public string? 產品資訊檔案_稽查人員主鍵 { get; set; }

    public string? 產品資訊檔案_承辦人員主鍵 { get; set; }

    public string? 產品資訊檔案_審查人員主鍵 { get; set; }

    public string? 產品資訊檔案_作業階段 { get; set; }

    public string? 產品資訊檔案_結案狀態 { get; set; }

    public DateOnly? 產品資訊檔案_結案日期 { get; set; }
}
