using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 紀錄_物品稽查主表
{
    public int 已完成物品稽查編號 { get; set; }

    /// <summary>
    /// 物品稽查序號
    /// </summary>
    public int 物品稽查編號 { get; set; }

    /// <summary>
    /// 資料界接外部Key
    /// </summary>
    public string? FMS介接編號 { get; set; }

    /// <summary>
    /// 稽查序號(由稽查事件頁面傳來)
    /// </summary>
    public int 稽查主檔編號 { get; set; }

    /// <summary>
    /// 稽查物品註記-抽驗稽查(Y:有勾選、N:無勾選)
    /// </summary>
    public string? 抽驗稽查 { get; set; }

    /// <summary>
    /// 稽查物品註記-熟食稽查(Y:有勾選、N:無勾選)
    /// </summary>
    public string? 熟食稽查 { get; set; }

    /// <summary>
    /// 稽查物品註記-標示稽查(Y:有勾選、N:無勾選)
    /// </summary>
    public string? 標示稽查 { get; set; }

    /// <summary>
    /// 記錄專案名稱的ID,用逗號分隔
    /// </summary>
    public string? 專案編號 { get; set; }

    /// <summary>
    /// 產品別主類ID
    /// </summary>
    public string? 產品別主分類編號 { get; set; }

    /// <summary>
    /// 產品別次類ID
    /// </summary>
    public string? 產品別次分類編號 { get; set; }

    /// <summary>
    /// 產品別細類ID(按&quot;搜尋&quot;時對應至品名)
    /// </summary>
    public string? 產品別細分類編號 { get; set; }

    /// <summary>
    /// 品名
    /// </summary>
    public string? 品名 { get; set; }

    /// <summary>
    /// 物品名稱
    /// </summary>
    public string? 物品名稱 { get; set; }

    /// <summary>
    /// 物品編號，由使用者自行輸入
    /// </summary>
    public string? 物品編號 { get; set; }

    /// <summary>
    /// 物品抽驗-物品重量
    /// </summary>
    public string? 物品重量 { get; set; }

    /// <summary>
    /// 物品重量單位
    /// </summary>
    public int? 物品重量單位代碼 { get; set; }

    /// <summary>
    /// 物品抽驗-外觀ID
    /// </summary>
    public int? 物品外觀代碼 { get; set; }

    /// <summary>
    /// 物品抽驗-物品單位ID
    /// </summary>
    public int? 物品單位代碼 { get; set; }

    /// <summary>
    /// 物品抽驗-物品保存狀況ID
    /// </summary>
    public int? 物品保存狀況代碼 { get; set; }

    /// <summary>
    /// 物品抽驗-物品包裝ID
    /// </summary>
    public int? 物品包裝代碼 { get; set; }

    /// <summary>
    /// 物品抽驗-製造日期
    /// </summary>
    public DateOnly? 物品製造日期 { get; set; }

    /// <summary>
    /// 物品抽驗-製造日期民國年月日(ex:1000123)
    /// </summary>
    public string? 國曆物品製造日期 { get; set; }

    /// <summary>
    /// 物品抽驗-製造日期未標示(Y:勾選、N:無勾選)
    /// </summary>
    public string? 物品製造日期未標示 { get; set; }

    /// <summary>
    /// 物品抽驗-有效日期
    /// </summary>
    public DateOnly? 物品有效日期 { get; set; }

    /// <summary>
    /// 物品抽驗-有效日期民國年月日(ex:1000123)
    /// </summary>
    public string? 國曆物品有效日期 { get; set; }

    /// <summary>
    /// 物品抽驗-有效日期未標示(Y:勾選、N:無勾選)
    /// </summary>
    public string? 物品有效日期未標示 { get; set; }

    /// <summary>
    /// 物品抽驗-批號
    /// </summary>
    public string? 物品批號 { get; set; }

    /// <summary>
    /// 物品抽驗-稽查件數
    /// </summary>
    public string? 抽驗_稽查件數 { get; set; }

    /// <summary>
    /// 物品抽驗-違規件數
    /// </summary>
    public string? 抽驗_違規件數 { get; set; }

    /// <summary>
    /// 製造商業者編號(欄位上輸入的編號,搜尋匯入時,代入業者外部ID)
    /// </summary>
    public string? 製造商編號 { get; set; }

    /// <summary>
    /// 製造商業者(縣市別)
    /// </summary>
    public string? 製造商所屬縣市 { get; set; }

    /// <summary>
    /// 製造商名稱
    /// </summary>
    public string? 製造商名稱 { get; set; }

    /// <summary>
    /// 製造商電話
    /// </summary>
    public string? 製造商電話 { get; set; }

    /// <summary>
    /// 製造商地址
    /// </summary>
    public string? 製造商地址 { get; set; }

    /// <summary>
    /// 食品種類ID(代碼檔)分為國產食品,進口食品,食品添加物
    /// </summary>
    public string? 食品地區別 { get; set; }

    /// <summary>
    /// 原產地ID(國別代碼檔)
    /// </summary>
    public string? 原產地代碼 { get; set; }

    /// <summary>
    /// 是否標示原產地，Y:有、N:無
    /// </summary>
    public string? 標示產地 { get; set; }

    /// <summary>
    /// 原產地證明，1:有、2:無
    /// </summary>
    public string? 原產地證明 { get; set; }

    /// <summary>
    /// 來源商編號(業者外部ID,欄位上輸入的編號,搜尋匯入時,代入業者外部ID)
    /// </summary>
    public string? 來源商編號 { get; set; }

    /// <summary>
    /// 來源商名稱
    /// </summary>
    public string? 來源商名稱 { get; set; }

    /// <summary>
    /// 來源商電話
    /// </summary>
    public string? 來源商電話 { get; set; }

    /// <summary>
    /// 來源商地址
    /// </summary>
    public string? 來源商地址 { get; set; }

    /// <summary>
    /// 嫌疑食品記錄-購入數量
    /// </summary>
    public int? 嫌疑食品記錄_購入數量 { get; set; }

    /// <summary>
    /// 嫌疑食品記錄-現有數量
    /// </summary>
    public int? 嫌疑食品記錄_現有數量 { get; set; }

    /// <summary>
    /// 嫌疑食品記錄-抽樣數量
    /// </summary>
    public int? 嫌疑食品記錄_抽樣數量 { get; set; }

    /// <summary>
    /// 嫌疑食品記錄-沒入數量
    /// </summary>
    public int? 嫌疑食品記錄_沒入數量 { get; set; }

    /// <summary>
    /// 嫌疑食品記錄-封存數量
    /// </summary>
    public int? 嫌疑食品記錄_封存數量 { get; set; }

    /// <summary>
    /// 嫌疑食品記錄-封存編號
    /// </summary>
    public string? 嫌疑食品記錄_封存編號 { get; set; }

    /// <summary>
    /// 嫌疑食品記錄-購入日期
    /// </summary>
    public DateOnly? 嫌疑食品記錄_購入日期 { get; set; }

    /// <summary>
    /// 嫌疑食品記錄-購入方法
    /// </summary>
    public string? 嫌疑食品記錄_購入方法 { get; set; }

    /// <summary>
    /// 嫌疑食品記錄-購入來源
    /// </summary>
    public string? 嫌疑食品記錄_購入來源 { get; set; }

    /// <summary>
    /// 嫌疑食品記錄-放置地點
    /// </summary>
    public string? 嫌疑食品記錄_放置地點 { get; set; }

    /// <summary>
    /// 嫌疑食品記錄-保管情形
    /// </summary>
    public string? 嫌疑食品記錄_保管情形 { get; set; }

    /// <summary>
    /// 嫌疑食品記錄-違規/嫌疑事項
    /// </summary>
    public string? 嫌疑食品記錄_違規嫌疑事項 { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? FMS備註 { get; set; }

    /// <summary>
    /// 熟食稽查-稽查件數
    /// </summary>
    public string? 熟食_稽查件數 { get; set; }

    /// <summary>
    /// 熟食稽查-違規件數
    /// </summary>
    public string? 熟食_違規件數 { get; set; }

    /// <summary>
    /// 熟食稽查-熟食稽查紀錄代碼(多選,逗號分隔)
    /// </summary>
    public string? 熟食_稽查記錄 { get; set; }

    /// <summary>
    /// 抽查作業記錄
    /// </summary>
    public string? 抽查作業記錄備註 { get; set; }

    /// <summary>
    /// 結案 (Y結案 N未結案)
    /// </summary>
    public string? 熟食_結案狀態 { get; set; }

    /// <summary>
    /// 轉LIMS檢驗  (Y是 N否)
    /// </summary>
    public string? 轉LIMS檢驗 { get; set; }

    /// <summary>
    /// 類別 1.通路商 2.加工廠 3.餐飲業 4.販賣業
    /// </summary>
    public string? 類別 { get; set; }

    public string? 檢驗判定 { get; set; }

    public string? 備註 { get; set; }

    public string? FMS介接稽查編號 { get; set; }

    public string? FMS介接縣市編號 { get; set; }

    public string? 油炸油_酸價快篩 { get; set; }

    public string? 油炸油_酸價快篩_快篩結果 { get; set; }

    public string? 油炸油_總極性物質快篩 { get; set; }

    public string? 油炸油_總極性物質快篩_快篩結果 { get; set; }

    public string? 熟食_作業階段 { get; set; }

    public string? 熟食_作業負責人員編號 { get; set; }

    public string? 油炸油_酸價_登錄油炸油檢驗結果 { get; set; }

    public string? 油炸油_酸價_合不合格_登錄油炸油檢驗結果 { get; set; }

    public string? 油炸油_總極性物質_登錄油炸油檢驗結果 { get; set; }

    public string? 油炸油_總極性物質_合不合格_登錄油炸油檢驗結果 { get; set; }

    public int? 油炸油_檢驗件數 { get; set; }

    public int? 油炸油_違規件數 { get; set; }

    public string? 熟食_稽查人員編號 { get; set; }

    public string? 熟食_承辦人員編號 { get; set; }

    public string? 熟食_審查人員編號 { get; set; }

    public string? 熟食_結案日期 { get; set; }

    public string? 油炸油稽查 { get; set; }

    public double? 油炸油_總極性物質快篩_檢驗值 { get; set; }

    public double? 油炸油_酸價快篩_檢驗值 { get; set; }

    public double? 油炸油_酸價快篩_檢驗結果值 { get; set; }

    public double? 油炸油_總極性物質_檢驗值 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員編號 { get; set; }

    public string? 熟食_衛生局主鍵 { get; set; }

    public string? 抽驗_衛生局主鍵 { get; set; }

    public string? 標示_衛生局主鍵 { get; set; }

    public string? 專案名稱 { get; set; }

    public string? 油炸油_作業階段 { get; set; }

    public string? 油炸油_作業負責人員編號 { get; set; }

    public string? 油炸油_稽查人員編號 { get; set; }

    public string? 油炸油_承辦人員編號 { get; set; }

    public string? 油炸油_審查人員編號 { get; set; }

    public string? 油炸油_結案日期 { get; set; }

    public string? 油炸油_結案狀態 { get; set; }

    public string? 油炸油_違法食品安全衛生管理法 { get; set; }

    public string? 油炸油_限期改善 { get; set; }

    public DateTime? 油炸油_限期改善日期 { get; set; }

    public string? 油炸油_國曆限期改善日期 { get; set; }

    public string? 油炸油_飭其收回重製 { get; set; }

    public string? 油炸油_禁止出售或沒收 { get; set; }

    public string? 油炸油_廢棄重量 { get; set; }

    public string? 油炸油_罰鍰金額 { get; set; }

    public string? 油炸油_停業 { get; set; }

    public string? 油炸油_移送法院 { get; set; }

    public string? 油炸油_備註 { get; set; }

    public string? 油炸油_移外縣市 { get; set; }

    public string? 油炸油_移外縣市名稱 { get; set; }

    public string? 油炸油_移外縣市函送文號 { get; set; }

    public string? 油炸油_移外縣市函送日期 { get; set; }

    public string? 油炸油_移外縣市市招名稱 { get; set; }

    public string? 油炸油_移外縣市負責人 { get; set; }

    public string? 油炸油_移外縣市業者地址 { get; set; }

    public string? 油炸油_移外縣市移外原因 { get; set; }

    public int? 油炸油_前一次稽查編號 { get; set; }

    public int? 油炸油_複查次數 { get; set; }

    public int? 油炸油_最初稽查編號 { get; set; }

    public string? 油炸油_稽查件數 { get; set; }

    public string? 油炸油_衛生局稽查系統主鍵 { get; set; }

    public string? 油炸油_上一次稽查衛生局主鍵 { get; set; }

    public string? 油炸油_第一次稽查衛生局主鍵 { get; set; }

    /// <summary>
    /// 證照GMP
    /// </summary>
    public string? 產品認證TQF { get; set; }

    /// <summary>
    /// 證照GSP
    /// </summary>
    public string? 產品認證CAS { get; set; }

    public string? 物品批號未標示 { get; set; }

    public string? 修改理由 { get; set; }
}
