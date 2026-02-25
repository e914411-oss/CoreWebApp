using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 一級品管稽查主檔
{
    public int 一級品管ID { get; set; }

    public int? 稽查主檔ID { get; set; }

    public string? 縣市代碼檔 { get; set; }

    public DateOnly? 稽查日期 { get; set; }

    public string? 記錄專案名稱的ID { get; set; }

    public string? 專案名稱_用逗號分隔 { get; set; }

    public string? 業者主類別 { get; set; }

    public string? 最近一次強制性檢驗日期 { get; set; }

    public string? 是否為應訂定食品安全監測計畫之類別及規模 { get; set; }

    public string? 有無食品安全監測計畫 { get; set; }

    public string? 是否為應設置實驗室之類別及規模 { get; set; }

    public string? 有無設置實驗室 { get; set; }

    public string? 稽查結果_合格 { get; set; }

    public string? 稽查結果_輔導改善 { get; set; }

    public string? 稽查結果_限期改善日期 { get; set; }

    public string? 稽查結果_複查合格 { get; set; }

    public string? 稽查結果_複查不合格 { get; set; }

    public string? 稽查結果_移縣市辦理 { get; set; }

    public string? 稽查結果_停廢歇業_YesNo { get; set; }

    public string? 稽查結果_停廢歇業 { get; set; }

    public string? 稽查結果_罰款金額 { get; set; }

    public string? 稽查結果_移送法院處理 { get; set; }

    public string? 稽查結果_其他 { get; set; }

    public string? 稽查結果_不合格 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 稽查結果ID { get; set; }

    public string? 稽查人員 { get; set; }

    public string? 承辦人員 { get; set; }

    public string? 審查人員 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 結案狀態 { get; set; }

    public string? 結案日期 { get; set; }

    public string? 產品責任保險 { get; set; }

    public DateOnly? 保險期間開始年月日 { get; set; }

    public DateOnly? 保險期間結束年月日 { get; set; }

    public string? 保險期間開始民國年月日 { get; set; }

    public string? 保險期間結束民國年月日 { get; set; }

    public string? 案件狀態 { get; set; }

    public string? 案件執行人員 { get; set; }

    public string? 食品安全衛生管理法第七條第一項 { get; set; }

    public string? 食品安全衛生管理法第七條第二項 { get; set; }

    public string? 食品安全衛生管理法第七條第三項 { get; set; }

    public string? 處理情形_移送法院 { get; set; }

    public string? 處理情形_限期改善 { get; set; }

    public DateOnly? 處理情形_限期改善日期 { get; set; }

    public string? 處理情形_移外縣市 { get; set; }

    public string? 處理情形_沒入銷毀件數 { get; set; }

    public string? 處理情形_廢止營業或工廠登記證號 { get; set; }

    public string? 處理情形_產品定期封存 { get; set; }

    public string? 處理情形_廢止許可證 { get; set; }

    public string? 處理情形_停業 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public string? 處理情形_歇業 { get; set; }

    public DateOnly? 移外縣市_函送日期 { get; set; }

    public string? 移外縣市_函送文號 { get; set; }

    public string? 移外縣市_移外縣市 { get; set; }

    public string? 移外縣市_市招名稱 { get; set; }

    public string? 移外縣市_負責人 { get; set; }

    public string? 移外縣市_業者地址 { get; set; }

    public string? 移外縣市_移外原因 { get; set; }

    public string? 備註說明 { get; set; }

    public int? 前一次稽查id { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public string? 第一次稽查衛生局主鍵 { get; set; }

    public string? 上一次稽查衛生局主鍵 { get; set; }

    public string? 修改人員 { get; set; }

    public DateTime? 修改時間 { get; set; }

    public string? 是否應實施強制性檢驗之類別及規模 { get; set; }

    public string? 強制檢驗是否符合 { get; set; }

    public string? 強制檢驗不符合項目 { get; set; }

    public string? 訂定食品安全監測計劃是否符合 { get; set; }

    public string? 設置實驗室是否符合 { get; set; }

    public string? 承辦意見 { get; set; }

    public string? 稽查結果_不適用 { get; set; }
}
