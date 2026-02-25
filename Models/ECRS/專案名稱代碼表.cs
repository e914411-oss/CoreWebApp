using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 專案名稱代碼表
{
    /// <summary>
    /// 識別碼
    /// </summary>
    public int 專案名稱代碼表主鍵 { get; set; }

    /// <summary>
    /// 建立部門
    /// </summary>
    public string? 建立部門 { get; set; }

    /// <summary>
    /// 專案年度
    /// </summary>
    public string? 專案截止日期 { get; set; }

    /// <summary>
    /// 專案名稱
    /// </summary>
    public string? 專案名稱 { get; set; }

    /// <summary>
    /// GHP  Y/N
    /// </summary>
    public string? GHP專案 { get; set; }

    /// <summary>
    /// 標示  Y/N
    /// </summary>
    public string? 標示專案 { get; set; }

    /// <summary>
    /// 抽驗 Y/N
    /// </summary>
    public string? 抽驗專案 { get; set; }

    /// <summary>
    /// 熟食 Y/N
    /// </summary>
    public string? 熟食專案 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public string? 保留欄位用 { get; set; }

    public string? 油炸油專案 { get; set; }

    public string? HACCP專案 { get; set; }

    public string? 查驗登記工廠專案_健康食品工廠 { get; set; }

    public string? 查驗登記產品專案_健康食品 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? GHP專案_體檢情形 { get; set; }

    public string? 查驗登記工廠專案_食品添加物工廠 { get; set; }

    public string? 查驗登記工廠專案_國產維生素錠狀膠囊狀工廠 { get; set; }

    public string? 查驗登記產品專案_食品添加物 { get; set; }

    public string? 查驗登記產品專案_國產維生素錠狀膠囊狀食品 { get; set; }

    public string? 查驗登記產品專案_輸入錠狀膠囊狀食品 { get; set; }

    public string? 查驗登記產品專案_病人用特殊營養食品 { get; set; }

    public string? 查驗登記產品專案_嬰兒配方食品及較大嬰兒配方輔助食品 { get; set; }

    public string? 是否啟用 { get; set; }

    public string? 真空包裝專案 { get; set; }

    public string? GHP專案_標示符合性 { get; set; }

    public string? 專案承辦人員主鍵 { get; set; }

    public string? 是否有專案目標數 { get; set; }

    public string? 是否有設定浮動欄位 { get; set; }

    public string? 瘦身美容業稽專案 { get; set; }

    public string? 化粧品工廠專案 { get; set; }

    public string? 化粧品專案 { get; set; }

    public string? 藥商藥局醫療機構專案 { get; set; }

    public string? 藥品專案 { get; set; }

    public string? 藥廠自用原料查核專案 { get; set; }

    public string? 藥品回收專案 { get; set; }

    public string? 醫療器材專案 { get; set; }

    public string? 稽查事由及內容 { get; set; }

    public string? 派案 { get; set; }

    public bool? 是否派案 { get; set; }

    public string? 登錄查核專案 { get; set; }

    public string? 追溯追蹤專案 { get; set; }

    public string? 一級品管專案 { get; set; }

    public string? 食品郵購買賣定型化契約 { get; set; }

    public string? 餐飲禮券定型化契約 { get; set; }

    public string? 訂席_外燴定型化契約 { get; set; }

    public string? 藥品回收後續處理結果 { get; set; }

    public string? 醫療器材回收後續處理結果 { get; set; }

    public string? 化粧品回收後續處理結果 { get; set; }

    public string? 化粧品業者專案 { get; set; }

    public string? 產品責任保險 { get; set; }

    public string? 來源文件保存 { get; set; }

    public string? 逾期食品保存 { get; set; }

    public string? 衛生管理人員 { get; set; }

    public string? 專門職業或技術證照人員 { get; set; }
}
