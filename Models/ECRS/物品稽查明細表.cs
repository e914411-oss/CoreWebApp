using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 物品稽查明細表
{
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
    /// 稽查物品註記-抽驗稽查
    /// </summary>
    public string? 抽驗稽查 { get; set; }

    /// <summary>
    /// 稽查物品註記-熟食稽查
    /// </summary>
    public string? 熟食稽查 { get; set; }

    /// <summary>
    /// 稽查物品註記-標示稽查
    /// </summary>
    public string? 標示稽查 { get; set; }

    /// <summary>
    /// 專案名稱
    /// </summary>
    public string? 專案編號 { get; set; }

    /// <summary>
    /// 產品別主類別
    /// </summary>
    public string? 產品別主分類編號 { get; set; }

    /// <summary>
    /// 產品別次類別
    /// </summary>
    public string? 產品別次分類編號 { get; set; }

    /// <summary>
    /// 產品別細類別
    /// </summary>
    public string? 產品別細分類編號 { get; set; }

    /// <summary>
    /// 產品名稱
    /// </summary>
    public string? 品名 { get; set; }

    /// <summary>
    /// 物品名稱
    /// </summary>
    public string? 物品名稱 { get; set; }

    /// <summary>
    /// 物品編號
    /// </summary>
    public string? 物品編號 { get; set; }

    /// <summary>
    /// 物品重量
    /// </summary>
    public string? 物品重量 { get; set; }

    /// <summary>
    /// 物品重量單位
    /// </summary>
    public int? 物品重量單位代碼 { get; set; }

    /// <summary>
    /// 物品外觀
    /// </summary>
    public int? 物品外觀代碼 { get; set; }

    /// <summary>
    /// 物品單位
    /// </summary>
    public int? 物品單位代碼 { get; set; }

    /// <summary>
    /// 物品保存狀況
    /// </summary>
    public int? 物品保存狀況代碼 { get; set; }

    /// <summary>
    /// 物品包裝
    /// </summary>
    public int? 物品包裝代碼 { get; set; }

    /// <summary>
    /// 物品抽驗-製造日期
    /// </summary>
    public DateOnly? 物品製造日期 { get; set; }

    /// <summary>
    /// 物品製造日期
    /// </summary>
    public string? 國曆物品製造日期 { get; set; }

    /// <summary>
    /// 物品製造日期未標示
    /// </summary>
    public string? 物品製造日期未標示 { get; set; }

    /// <summary>
    /// 物品抽驗-有效日期
    /// </summary>
    public DateOnly? 物品有效日期 { get; set; }

    /// <summary>
    /// 物品有效日期
    /// </summary>
    public string? 國曆物品有效日期 { get; set; }

    /// <summary>
    /// 物品有效日期未標示
    /// </summary>
    public string? 物品有效日期未標示 { get; set; }

    /// <summary>
    /// 物品批號
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
    /// 製造商業者編號
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
    /// 食品地區別
    /// </summary>
    public string? 食品地區別 { get; set; }

    /// <summary>
    /// 原產地
    /// </summary>
    public string? 原產地代碼 { get; set; }

    /// <summary>
    /// 是否標示原產地
    /// </summary>
    public string? 標示產地 { get; set; }

    /// <summary>
    /// 原產地證明
    /// </summary>
    public string? 原產地證明 { get; set; }

    /// <summary>
    /// 來源商編號
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
    /// 熟食稽查記錄
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

    /// <summary>
    /// 檢驗總判定
    /// </summary>
    public string? 檢驗判定 { get; set; }

    /// <summary>
    /// 備註(欄寬50字)
    /// </summary>
    public string? 備註 { get; set; }

    /// <summary>
    /// 外部稽查編號
    /// </summary>
    public string? FMS介接稽查編號 { get; set; }

    /// <summary>
    /// 外部縣市代碼
    /// </summary>
    public string? FMS介接縣市編號 { get; set; }

    /// <summary>
    /// 酸價(快篩)
    /// </summary>
    public string? 油炸油_酸價快篩 { get; set; }

    /// <summary>
    /// 酸價(快篩)-快篩結果
    /// </summary>
    public string? 油炸油_酸價快篩_快篩結果 { get; set; }

    /// <summary>
    /// 總極性物質(快篩)
    /// </summary>
    public string? 油炸油_總極性物質快篩 { get; set; }

    /// <summary>
    /// 總極性物質(快篩)-快篩結果
    /// </summary>
    public string? 油炸油_總極性物質快篩_快篩結果 { get; set; }

    /// <summary>
    /// 作業階段
    /// </summary>
    public string? 熟食_作業階段 { get; set; }

    /// <summary>
    /// 當前作業人員
    /// </summary>
    public string? 熟食_作業負責人員編號 { get; set; }

    /// <summary>
    /// 酸價
    /// </summary>
    public string? 油炸油_酸價_登錄油炸油檢驗結果 { get; set; }

    /// <summary>
    /// 酸價-合不合格
    /// </summary>
    public string? 油炸油_酸價_合不合格_登錄油炸油檢驗結果 { get; set; }

    /// <summary>
    /// 總極性物質
    /// </summary>
    public string? 油炸油_總極性物質_登錄油炸油檢驗結果 { get; set; }

    /// <summary>
    /// 總極性物質-合不合格
    /// </summary>
    public string? 油炸油_總極性物質_合不合格_登錄油炸油檢驗結果 { get; set; }

    /// <summary>
    /// 油炸油檢驗件數
    /// </summary>
    public int? 油炸油_檢驗件數 { get; set; }

    /// <summary>
    /// 油炸油違規件數
    /// </summary>
    public int? 油炸油_違規件數 { get; set; }

    /// <summary>
    /// 稽查人員
    /// </summary>
    public string? 熟食_稽查人員編號 { get; set; }

    /// <summary>
    /// 承辦人員
    /// </summary>
    public string? 熟食_承辦人員編號 { get; set; }

    /// <summary>
    /// 審查人員
    /// </summary>
    public string? 熟食_審查人員編號 { get; set; }

    /// <summary>
    /// 結案日期
    /// </summary>
    public string? 熟食_結案日期 { get; set; }

    /// <summary>
    /// 稽查物品註記-油炸油稽查
    /// </summary>
    public string? 油炸油稽查 { get; set; }

    /// <summary>
    /// 總極性物質(快篩)-檢驗值
    /// </summary>
    public double? 油炸油_總極性物質快篩_檢驗值 { get; set; }

    /// <summary>
    /// 酸價(快篩)-檢驗值
    /// </summary>
    public double? 油炸油_酸價快篩_檢驗值 { get; set; }

    /// <summary>
    /// 酸價檢驗值
    /// </summary>
    public double? 油炸油_酸價快篩_檢驗結果值 { get; set; }

    /// <summary>
    /// 總極性物質檢驗值
    /// </summary>
    public double? 油炸油_總極性物質_檢驗值 { get; set; }

    /// <summary>
    /// 不合格件數(停用)
    /// </summary>
    public string? 測試失敗數量 { get; set; }

    /// <summary>
    /// 異動日期
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? 異動人員編號 { get; set; }

    /// <summary>
    /// 衛生局主鍵-熟食
    /// </summary>
    public string? 熟食_衛生局主鍵 { get; set; }

    /// <summary>
    /// 衛生局主鍵-抽驗
    /// </summary>
    public string? 抽驗_衛生局主鍵 { get; set; }

    /// <summary>
    /// 衛生局主鍵-標示
    /// </summary>
    public string? 標示_衛生局主鍵 { get; set; }

    /// <summary>
    /// 衛生局主鍵
    /// </summary>
    public string? 衛生局主鍵 { get; set; }

    /// <summary>
    /// 標示稽查件數(停用)
    /// </summary>
    public string? 標示稽查件數 { get; set; }

    /// <summary>
    /// 標示件數(停用)
    /// </summary>
    public string? 標示件數 { get; set; }

    /// <summary>
    /// 專案中文名稱
    /// </summary>
    public string? 專案名稱 { get; set; }

    /// <summary>
    /// 案件狀態-油炸油
    /// </summary>
    public string? 油炸油_作業階段 { get; set; }

    /// <summary>
    /// 案件負責人-油炸油
    /// </summary>
    public string? 油炸油_作業負責人員編號 { get; set; }

    /// <summary>
    /// 稽查員-油炸油
    /// </summary>
    public string? 油炸油_稽查人員編號 { get; set; }

    /// <summary>
    /// 承辦員-油炸油
    /// </summary>
    public string? 油炸油_承辦人員編號 { get; set; }

    /// <summary>
    /// 審查員-油炸油
    /// </summary>
    public string? 油炸油_審查人員編號 { get; set; }

    /// <summary>
    /// 結案日期-油炸油
    /// </summary>
    public string? 油炸油_結案日期 { get; set; }

    /// <summary>
    /// 結案狀態-油炸油
    /// </summary>
    public string? 油炸油_結案狀態 { get; set; }

    /// <summary>
    /// 油炸油稽查違法食品安全衛生管理法
    /// </summary>
    public string? 油炸油_違法食品安全衛生管理法 { get; set; }

    /// <summary>
    /// 油炸由稽查-限期改善
    /// </summary>
    public string? 油炸油_限期改善 { get; set; }

    /// <summary>
    /// 油炸油限期改善日期
    /// </summary>
    public DateTime? 油炸油_限期改善日期 { get; set; }

    /// <summary>
    /// 油炸由稽查-限期改善日期
    /// </summary>
    public string? 油炸油_國曆限期改善日期 { get; set; }

    /// <summary>
    /// 油炸油稽查-飭其收回重製
    /// </summary>
    public string? 油炸油_飭其收回重製 { get; set; }

    /// <summary>
    /// 油炸油稽查-禁止出售或沒收
    /// </summary>
    public string? 油炸油_禁止出售或沒收 { get; set; }

    /// <summary>
    /// 油炸油稽查-廢棄重量
    /// </summary>
    public string? 油炸油_廢棄重量 { get; set; }

    /// <summary>
    /// 油炸油稽查-罰鍰金額
    /// </summary>
    public string? 油炸油_罰鍰金額 { get; set; }

    /// <summary>
    /// 油炸油稽查-停業
    /// </summary>
    public string? 油炸油_停業 { get; set; }

    /// <summary>
    /// 油炸油稽查-移送法院
    /// </summary>
    public string? 油炸油_移送法院 { get; set; }

    /// <summary>
    /// 油炸油稽查-備註
    /// </summary>
    public string? 油炸油_備註 { get; set; }

    /// <summary>
    /// 油炸油稽查-移外縣市
    /// </summary>
    public string? 油炸油_移外縣市 { get; set; }

    /// <summary>
    /// 油炸油稽查-移外縣市名稱
    /// </summary>
    public string? 油炸油_移外縣市名稱 { get; set; }

    /// <summary>
    /// 油炸油稽查-移外縣市函送文號
    /// </summary>
    public string? 油炸油_移外縣市函送文號 { get; set; }

    /// <summary>
    /// 油炸油稽查-移外縣市函送日期
    /// </summary>
    public string? 油炸油_移外縣市函送日期 { get; set; }

    /// <summary>
    /// 油炸油稽查-移外縣市市招名稱
    /// </summary>
    public string? 油炸油_移外縣市市招名稱 { get; set; }

    /// <summary>
    /// 油炸油稽查-移外縣市負責人
    /// </summary>
    public string? 油炸油_移外縣市負責人 { get; set; }

    /// <summary>
    /// 油炸油稽查-移外縣市業者地址
    /// </summary>
    public string? 油炸油_移外縣市業者地址 { get; set; }

    /// <summary>
    /// 油炸油稽查-移外縣市移外原因
    /// </summary>
    public string? 油炸油_移外縣市移外原因 { get; set; }

    /// <summary>
    /// 前次稽查ID-油炸油
    /// </summary>
    public int? 油炸油_前一次稽查編號 { get; set; }

    /// <summary>
    /// 稽查次數-油炸油
    /// </summary>
    public int? 油炸油_複查次數 { get; set; }

    /// <summary>
    /// 第一次稽查ID-油炸油
    /// </summary>
    public int? 油炸油_最初稽查編號 { get; set; }

    /// <summary>
    /// 油炸油稽查件數
    /// </summary>
    public string? 油炸油_稽查件數 { get; set; }

    /// <summary>
    /// 衛生局主鍵-油炸油
    /// </summary>
    public string? 油炸油_衛生局稽查系統主鍵 { get; set; }

    /// <summary>
    /// 前次稽查衛生局主鍵
    /// </summary>
    public string? 油炸油_上一次稽查衛生局主鍵 { get; set; }

    /// <summary>
    /// 第一次稽查衛生局主鍵
    /// </summary>
    public string? 油炸油_第一次稽查衛生局主鍵 { get; set; }

    /// <summary>
    /// 產品認證GMP
    /// </summary>
    public string? 產品認證TQF { get; set; }

    /// <summary>
    /// 產品認證CAS&apos;
    /// </summary>
    public string? 產品認證CAS { get; set; }

    /// <summary>
    /// 物品批號未標示
    /// </summary>
    public string? 物品批號未標示 { get; set; }

    /// <summary>
    /// 稽查員姓名-熟食
    /// </summary>
    public string? 熟食_稽查人員姓名 { get; set; }

    /// <summary>
    /// 承辦員姓名-熟食
    /// </summary>
    public string? 熟食_承辦人員姓名 { get; set; }

    /// <summary>
    /// 審查員姓名-熟食
    /// </summary>
    public string? 熟食_審查人員姓名 { get; set; }

    /// <summary>
    /// 稽查員姓名-油炸油
    /// </summary>
    public string? 油炸油_稽查人員姓名 { get; set; }

    /// <summary>
    /// 承辦員姓名-油炸油
    /// </summary>
    public string? 油炸油_承辦人員姓名 { get; set; }

    /// <summary>
    /// 審查員姓名-油炸油
    /// </summary>
    public string? 油炸油_審查人員姓名 { get; set; }

    /// <summary>
    /// 產品認證-TAP
    /// </summary>
    public string? 產品認證TAP { get; set; }

    /// <summary>
    /// 產品認證-OTAP
    /// </summary>
    public string? 產品認證OTAP { get; set; }

    /// <summary>
    /// 產品認證-UTAP
    /// </summary>
    public string? 產品認證UTAP { get; set; }

    /// <summary>
    /// 產品認證-Organic
    /// </summary>
    public string? 產品認證_有機認證 { get; set; }

    /// <summary>
    /// 產品認證f其他
    /// </summary>
    public string? 產品認證其他 { get; set; }

    /// <summary>
    /// 建立日期-熟食
    /// </summary>
    public DateOnly? 熟食_建立日期 { get; set; }

    /// <summary>
    /// 建立日期-油炸油
    /// </summary>
    public DateOnly? 油炸油_建立日期 { get; set; }

    /// <summary>
    /// 登打日與稽查日超過七日通知-熟食
    /// </summary>
    public string? 熟食稽查登打日期與稽查日期相差七日案件通知 { get; set; }

    /// <summary>
    /// 登打日與稽查日超過七日通知-油炸油
    /// </summary>
    public string? 油炸油稽查登打日期與稽查日期相差七日案件通知 { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateOnly? 物品稽查建立日期 { get; set; }

    /// <summary>
    /// 物品編號(系統給號)
    /// </summary>
    public string? 產品編號 { get; set; }

    public string? 製造商未標示 { get; set; }

    public string? 來源商未標示 { get; set; }

    public string? 檢驗系統_檢體主分類代碼 { get; set; }

    public string? 檢驗系統_檢體大分類代碼 { get; set; }

    public string? 檢驗系統_檢體中分類代碼 { get; set; }

    public string? 檢驗系統_檢體小分類代碼 { get; set; }

    public string? 檢驗系統_檢體分類代碼 { get; set; }

    public int? 標示_查驗類型編號 { get; set; }

    public string? 其它查驗說明 { get; set; }

    public string? 標示_產品查核管理 { get; set; }

    public string? 標示_有無下游廠商 { get; set; }

    public string? 原料原產地 { get; set; }

    public string? 原料原產地代碼 { get; set; }
}
