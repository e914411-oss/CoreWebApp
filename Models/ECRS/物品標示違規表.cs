using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 物品標示違規表
{
    /// <summary>
    /// 標示違規項目ID
    /// </summary>
    public int 物品標示違規編號 { get; set; }

    public string? FMS介接編號 { get; set; }

    public int 物品稽查編號 { get; set; }

    /// <summary>
    /// 品名,分為是否違規 Y:是 N:否,以下均相同
    /// </summary>
    public string? 品名 { get; set; }

    /// <summary>
    /// 內容物名稱
    /// </summary>
    public string? 內容物名稱 { get; set; }

    /// <summary>
    /// 內容物重量、容量或數量
    /// </summary>
    public string? 內容物重量容量或數量 { get; set; }

    /// <summary>
    /// 食品添加物名稱
    /// </summary>
    public string? 食品添加物名稱 { get; set; }

    /// <summary>
    /// 廠商名稱
    /// </summary>
    public string? 廠商名稱 { get; set; }

    /// <summary>
    /// 廠商地址
    /// </summary>
    public string? 廠商地址 { get; set; }

    /// <summary>
    /// 廠商電話
    /// </summary>
    public string? 廠商電話 { get; set; }

    /// <summary>
    /// 有效日期(或經公告指定應再標示製造日期、保存期限或保存條件者)
    /// </summary>
    public string? 有效日期 { get; set; }

    /// <summary>
    /// 乳品類品名
    /// </summary>
    public string? 乳品類品名 { get; set; }

    /// <summary>
    /// 乳品類原料名稱
    /// </summary>
    public string? 乳品類原料名稱 { get; set; }

    /// <summary>
    /// 乳品類保存期限及保存條件(方法)
    /// </summary>
    public string? 乳品類保存期限及保存條件 { get; set; }

    /// <summary>
    /// 乳品類鮮乳與保久乳標示原則
    /// </summary>
    public string? 乳品類鮮乳與保久乳標示原則 { get; set; }

    /// <summary>
    /// 食品添加物許可証字號
    /// </summary>
    public string? 食品添加物許可証字號 { get; set; }

    /// <summary>
    /// 食品添加物使用食品範圍、用量及限制
    /// </summary>
    public string? 食品添加物使用食品範圍用量及限制 { get; set; }

    /// <summary>
    /// 食品添加物字樣
    /// </summary>
    public string? 食品添加物字樣 { get; set; }

    /// <summary>
    /// 冷凍食品類別
    /// </summary>
    public string? 冷凍食品類別 { get; set; }

    /// <summary>
    /// 冷凍食品保存方法及條件
    /// </summary>
    public string? 冷凍食品保存方法及條件 { get; set; }

    /// <summary>
    /// 冷凍食品調理方法(需調理供食者)
    /// </summary>
    public string? 冷凍食品調理方法_需調理供食者 { get; set; }

    /// <summary>
    /// 食品字樣(錠狀、膠曩狀產品)
    /// </summary>
    public string? 食品字樣_錠狀膠曩狀產品 { get; set; }

    /// <summary>
    /// 酸度及使用方法(合成食醋)
    /// </summary>
    public string? 酸度及使用方法_合成食醋 { get; set; }

    /// <summary>
    /// 咖啡因標示(飲料類產品)
    /// </summary>
    public string? 咖啡因標示_飲料類產品 { get; set; }

    /// <summary>
    /// 警語
    /// </summary>
    public string? 警語 { get; set; }

    /// <summary>
    /// 無中文標示
    /// </summary>
    public string? 無中文標示 { get; set; }

    /// <summary>
    /// 標示涉不實/誇張/易生誤解/醫療效能
    /// </summary>
    public string? 標示涉不實_誇張_易生誤解_醫療效能 { get; set; }

    /// <summary>
    /// 逾有效日期(保存期限)
    /// </summary>
    public string? 逾有效日期_保存期限 { get; set; }

    /// <summary>
    /// 塗改有效日期/製造日期/保存期限
    /// </summary>
    public string? 塗改有效日期_製造日期_保存期限 { get; set; }

    /// <summary>
    /// 營養標示內容
    /// </summary>
    public string? 營養標示內容 { get; set; }

    /// <summary>
    /// 營養宣稱
    /// </summary>
    public string? 營養宣稱 { get; set; }

    /// <summary>
    /// 其他
    /// </summary>
    public string? 其他 { get; set; }

    /// <summary>
    /// 其他描述
    /// </summary>
    public string? 其他描述 { get; set; }

    /// <summary>
    /// 違反法條-標示違反食管法第十一條
    /// </summary>
    public string? 標示違反法條_食管法第十一條 { get; set; }

    /// <summary>
    /// 違反法條-標示違反食管法第十七條第一項
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十二條第一項 { get; set; }

    /// <summary>
    /// 違反法條-標示違反食管法第十七條第二項
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十二條第二項 { get; set; }

    /// <summary>
    /// 標示稽查-食品安全衛生管理法第二十五條第二項
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十五條第二項 { get; set; }

    /// <summary>
    /// 違反法條-標示違反食管法第十九條第一項
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十八條第一項 { get; set; }

    /// <summary>
    /// 違反法條-標示違反食管法第十九條第二項
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十八條第二項 { get; set; }

    /// <summary>
    /// 違反法條-標示違反健康食品法第六條
    /// </summary>
    public string? 違反法條_健康食品管理法第六條 { get; set; }

    /// <summary>
    /// 違反法條-標示違反健康食品法第十三條
    /// </summary>
    public string? 違反法條_健康食品管理法第十三條 { get; set; }

    /// <summary>
    /// 違反法條-標示違反健康食品法第十四條
    /// </summary>
    public string? 違反法條_健康食品管理法第十四條 { get; set; }

    /// <summary>
    /// 違反法條-標示違反其他法律
    /// </summary>
    public string? 違反法條_其他法律 { get; set; }

    /// <summary>
    /// 違反法條-標示移送法辦
    /// </summary>
    public string? 處理情形_移送法院 { get; set; }

    /// <summary>
    /// 標示罰鍰金額
    /// </summary>
    public string? 標示處理情形_罰鍰金額 { get; set; }

    /// <summary>
    /// 標示限期改善
    /// </summary>
    public string? 處理情形_國曆限期改善日期 { get; set; }

    /// <summary>
    /// 標示沒入銷毀件數
    /// </summary>
    public string? 處理情形_沒入銷毀件數 { get; set; }

    /// <summary>
    /// 標示稽查-廢止營業或工廠登記證號
    /// </summary>
    public string? 處理情形_廢止營業或工廠登記證號 { get; set; }

    /// <summary>
    /// 標示稽查-廢止許可證
    /// </summary>
    public string? 處理情形_廢止許可證 { get; set; }

    /// <summary>
    /// 標示稽查-違規情節描述
    /// </summary>
    public string? FMS違規情節描述 { get; set; }

    /// <summary>
    /// 標示稽查-移外縣市名稱
    /// </summary>
    public string? 移外縣市編號 { get; set; }

    /// <summary>
    /// 標示稽查-處理情形
    /// </summary>
    public string? FMS處理情形 { get; set; }

    public string? FMS備註 { get; set; }

    public string? FMS稽查人員 { get; set; }

    public string? FMS承辦人員 { get; set; }

    public string? FMS審查人員 { get; set; }

    public string? FMS標示_作業階段 { get; set; }

    public string? 標示_結案狀態 { get; set; }

    /// <summary>
    /// 結案日期
    /// </summary>
    public string? FMS國曆結案日期 { get; set; }

    /// <summary>
    /// 退件原因
    /// </summary>
    public string? 退件原因 { get; set; }

    public string? 退回註記 { get; set; }

    /// <summary>
    /// 異動日期
    /// </summary>
    public DateOnly? 異動日期 { get; set; }

    /// <summary>
    /// 異動日期民國年月日
    /// </summary>
    public string? 國曆異動日期 { get; set; }

    /// <summary>
    /// 標示稽查-備註(欄寬50字)
    /// </summary>
    public string? 承辦備註說明 { get; set; }

    /// <summary>
    /// 標示稽查-限期改善
    /// </summary>
    public string? 處理情形_限期改善 { get; set; }

    /// <summary>
    /// 標示稽查-移外縣市
    /// </summary>
    public string? 處理情形_移外縣市 { get; set; }

    /// <summary>
    /// 標示稽查-移外縣市函送文號
    /// </summary>
    public string? 移外縣市_函送文號 { get; set; }

    /// <summary>
    /// 標示稽查-移外縣市函送日期
    /// </summary>
    public string? 移外縣市_函送日期 { get; set; }

    /// <summary>
    /// 標示稽查-移外縣市市招名稱
    /// </summary>
    public string? 移外縣市_市招名稱 { get; set; }

    /// <summary>
    /// 標示稽查-移外縣市負責人
    /// </summary>
    public string? 移外縣市_負責人 { get; set; }

    /// <summary>
    /// 標示稽查-移外縣市業者地址
    /// </summary>
    public string? 移外縣市_業者地址 { get; set; }

    /// <summary>
    /// 標示稽查-移外縣市移外原因
    /// </summary>
    public string? 移外縣市_移外原因 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 作業負責人員 { get; set; }

    public string? 稽查人員 { get; set; }

    public string? 承辦人員 { get; set; }

    public string? 審查人員 { get; set; }

    public string? 結案日期 { get; set; }

    /// <summary>
    /// 標示稽查-食品安全衛生管理法第十五條第一項第七款
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第十五條第一項第七款 { get; set; }

    /// <summary>
    /// 標示稽查-食品安全衛生管理法第十五條第一項第八款
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第十五條第一項第八款 { get; set; }

    /// <summary>
    /// 標示稽查-食品安全衛生管理法第十五條第一項第九款
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第十五條第一項第九款 { get; set; }

    public string? 異動人員 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public string? 食品衛生管理法第十一條 { get; set; }

    public string? 食品衛生管理法第十二條 { get; set; }

    public string? 食品衛生管理法第十四條 { get; set; }

    public string? 食品衛生管理法第十七條 { get; set; }

    public string? 食品衛生管理法第十九條 { get; set; }

    /// <summary>
    /// 產品定期封存
    /// </summary>
    public string? 處理情形_產品定期封存 { get; set; }

    public string? 產品沒入銷毀 { get; set; }

    public string? 產品限期回收改正 { get; set; }

    public string? 國曆產品限期回收改正日期 { get; set; }

    public string? 產品限期改製 { get; set; }

    public string? 廢止許可證 { get; set; }

    /// <summary>
    /// 歇業
    /// </summary>
    public string? 處理情形_歇業 { get; set; }

    /// <summary>
    /// 標示稽查-停業
    /// </summary>
    public string? 處理情形_停業 { get; set; }

    public int? 前一次稽查編號 { get; set; }

    public int? 複查次數 { get; set; }

    public int? 最初稽查編號 { get; set; }

    public string? 產品銷毀數量 { get; set; }

    /// <summary>
    /// 標示稽查-食品安全衛生管理法第十五條第一項第十款
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第十五條第一項第十款 { get; set; }

    public string? 食品衛生管理法第十八條 { get; set; }

    public string? 食品衛生管理法第二十一條 { get; set; }

    /// <summary>
    /// 標示稽查-食品安全衛生管理法第二十六條
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十六條 { get; set; }

    /// <summary>
    /// 標示稽查-食品安全衛生管理法第二十七條
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十七條 { get; set; }

    public string? 乳品類工廠登記証字號 { get; set; }

    public string? 乳品類成分乳脂 { get; set; }

    public string? 乳品類成分乳固形物 { get; set; }

    public string? 分裝廠商名稱 { get; set; }

    public string? 分裝廠商地址 { get; set; }

    public string? 國內負責廠商名稱 { get; set; }

    public string? 國內負責廠商地址 { get; set; }

    public string? 國內負責廠商電話號碼 { get; set; }

    public string? 上一次稽查衛生局主鍵 { get; set; }

    public string? 第一次稽查衛生局主鍵 { get; set; }

    /// <summary>
    /// 標示稽查-食品安全衛生管理法第二十四條
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十四條 { get; set; }

    /// <summary>
    /// 標示稽查-食品安全衛生管理法第四十七條
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第四十七條 { get; set; }

    public string? 稽查人員姓名 { get; set; }

    public string? 承辦人員姓名 { get; set; }

    public string? 審查人員姓名 { get; set; }

    public DateOnly? 建立日期 { get; set; }

    public string? 登打日與稽查日超過七日通知 { get; set; }

    public string? 是否移出 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public byte[]? 工作紀錄PDF檔案 { get; set; }

    public string? 承辦意見 { get; set; }

    public string? 移送單位名稱 { get; set; }
}
