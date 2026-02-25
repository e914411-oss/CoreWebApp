using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記產品查核明細表
{
    public int 主鍵 { get; set; }

    public int? 查驗登記產品查核主表主鍵 { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public string? 專案名稱 { get; set; }

    /// <summary>
    /// 專案名稱 
    /// </summary>
    public string? 專案名稱主鍵 { get; set; }

    /// <summary>
    /// 稽查日期
    /// </summary>
    public DateOnly? 稽查日期 { get; set; }

    public string? 不使用1 { get; set; }

    public string? 不使用2 { get; set; }

    public string? 不使用3 { get; set; }

    public string? 不使用4 { get; set; }

    public int? 業者主鍵 { get; set; }

    public int? 查驗登記產品主鍵 { get; set; }

    /// <summary>
    /// 許可證字號\文號
    /// </summary>
    public string? 許可證字號 { get; set; }

    /// <summary>
    /// 產品名稱
    /// </summary>
    public string? 查驗登記產品中文名稱 { get; set; }

    /// <summary>
    /// 申請商名稱
    /// </summary>
    public string? 申請商名稱 { get; set; }

    /// <summary>
    /// 申請商統一編號
    /// </summary>
    public string? 申請商編號 { get; set; }

    /// <summary>
    /// 申請商電話
    /// </summary>
    public string? 申請商電話 { get; set; }

    /// <summary>
    /// 申請商負責人
    /// </summary>
    public string? 申請商負責人 { get; set; }

    /// <summary>
    /// 申請商地址
    /// </summary>
    public string? 申請商地址 { get; set; }

    /// <summary>
    /// 製造商名稱
    /// </summary>
    public string? 製造商名稱 { get; set; }

    /// <summary>
    /// 製造商統一編號
    /// </summary>
    public string? 製造商編號 { get; set; }

    /// <summary>
    /// 製造商電話
    /// </summary>
    public string? 製造商電話 { get; set; }

    /// <summary>
    /// 製造商負責人
    /// </summary>
    public string? 製造商負責人 { get; set; }

    /// <summary>
    /// 製造商地址
    /// </summary>
    public string? 製造商地址 { get; set; }

    /// <summary>
    /// 產品批號
    /// </summary>
    public string? 產品批號 { get; set; }

    public string? 違反法條_停用 { get; set; }

    /// <summary>
    /// 抽樣日期
    /// </summary>
    public string? 抽樣日期 { get; set; }

    /// <summary>
    /// 查核項目:保健功效成分含量符合性
    /// </summary>
    public string? 查核項目_保健功效成分含量符合性 { get; set; }

    /// <summary>
    /// 查核項目:營養素含量符合性
    /// </summary>
    public string? 查核項目_營養素含量符合性 { get; set; }

    /// <summary>
    /// 查核項目:衛生標準符合性
    /// </summary>
    public string? 查核項目_衛生標準符合性 { get; set; }

    /// <summary>
    /// 查核項目:產品標示
    /// </summary>
    public string? 查核項目_產品標示 { get; set; }

    /// <summary>
    /// 查核項目:產品標示-一般標示
    /// </summary>
    public string? 查核項目_產品標示_一般標示合格與否 { get; set; }

    /// <summary>
    /// 查核項目:產品標示-營養標示
    /// </summary>
    public string? 查核項目_產品標示_營養標示合格與否 { get; set; }

    /// <summary>
    /// 查核項目:產品標示-一般標示說明
    /// </summary>
    public string? 查核項目_產品標示_一般標示說明 { get; set; }

    /// <summary>
    /// 查核項目:產品標示-營養標示說明
    /// </summary>
    public string? 查核項目_產品標示_營養標示說明 { get; set; }

    public string? 違反條文_停用 { get; set; }

    /// <summary>
    /// 產品定期封存
    /// </summary>
    public string? 處理情形_產品定期封存 { get; set; }

    /// <summary>
    /// 產品沒入銷毀
    /// </summary>
    public string? 處理情形_產品沒入銷毀 { get; set; }

    /// <summary>
    /// 罰鍰金額
    /// </summary>
    public string? 處理情形_罰鍰金額 { get; set; }

    /// <summary>
    /// 移外縣市
    /// </summary>
    public string? 處理情形_移外縣市 { get; set; }

    /// <summary>
    /// 移外縣市函送文號
    /// </summary>
    public string? 移外縣市_函送文號 { get; set; }

    /// <summary>
    /// 移外縣市函送日期
    /// </summary>
    public string? 移外縣市_函送日期 { get; set; }

    /// <summary>
    /// 移外縣市名稱
    /// </summary>
    public string? 移外縣市主鍵 { get; set; }

    /// <summary>
    /// 移外縣市市招名稱
    /// </summary>
    public string? 移外縣市_市招名稱 { get; set; }

    /// <summary>
    /// 移外縣市負責人
    /// </summary>
    public string? 移外縣市_負責人 { get; set; }

    /// <summary>
    /// 移外縣市業者地址
    /// </summary>
    public string? 移外縣市_業者地址 { get; set; }

    /// <summary>
    /// 移外縣市移外原因
    /// </summary>
    public string? 移外縣市_移外原因 { get; set; }

    /// <summary>
    /// 備註說明
    /// </summary>
    public string? 承辦備註說明 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 作業負責人員主鍵 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 結案日期_停用 { get; set; }

    public string? 結案日期 { get; set; }

    public string? 國曆抽樣日期 { get; set; }

    /// <summary>
    /// 有效日期
    /// </summary>
    public string? 有效日期 { get; set; }

    /// <summary>
    /// 結案狀態,分為已結案,未結案 分為Y:已結案,N:未結案
    /// </summary>
    public string? 結案狀態 { get; set; }

    public string? 單位 { get; set; }

    public int? 數量 { get; set; }

    public string? 重量 { get; set; }

    public string? 外觀形狀 { get; set; }

    public string? 批號或日期 { get; set; }

    public string? 備註 { get; set; }

    public string? FMS介接主鍵 { get; set; }

    /// <summary>
    /// 產品限期回收改正
    /// </summary>
    public string? 處理情形_產品限期回收改正 { get; set; }

    /// <summary>
    /// 產品限期改製
    /// </summary>
    public string? 處理情形_產品限期改製 { get; set; }

    /// <summary>
    /// 廢止許可證
    /// </summary>
    public string? 處理情形_廢止許可證 { get; set; }

    /// <summary>
    /// 歇業
    /// </summary>
    public string? 處理情形_歇業 { get; set; }

    /// <summary>
    /// 停業
    /// </summary>
    public string? 處理情形_停業 { get; set; }

    /// <summary>
    /// 廢止營業或工廠登記
    /// </summary>
    public string? 處理情形_廢止營業或工廠登記 { get; set; }

    /// <summary>
    /// 移送法辦
    /// </summary>
    public string? 處理情形_移送法院 { get; set; }

    /// <summary>
    /// 備註(欄寬50字)
    /// </summary>
    public string? 備註2 { get; set; }

    public string? 查驗登記產品英文名稱 { get; set; }

    public string? 查驗登記產品類型代碼 { get; set; }

    public string? 產品類型代碼 { get; set; }

    /// <summary>
    /// 查核項目:食品添加物規格檢驗
    /// </summary>
    public string? 查核項目_食品添加物規格符合性 { get; set; }

    /// <summary>
    /// 查核項目:一般標示-品名
    /// </summary>
    public string? 查核項目_一般標示_品名_合格與否 { get; set; }

    /// <summary>
    /// 查核項目:一般標示-內容物名稱
    /// </summary>
    public string? 查核項目_一般標示_內容物名稱_合格與否 { get; set; }

    /// <summary>
    /// 查核項目:一般標示-內容物重量、容量或數量
    /// </summary>
    public string? 查核項目_一般標示_內容物重量容量或數量_合格與否 { get; set; }

    /// <summary>
    /// 查核項目:一般標示-食品添加物名稱
    /// </summary>
    public string? 查核項目_一般標示_食品添加物名稱_合格與否 { get; set; }

    /// <summary>
    /// 查核項目:一般標示-廠商資訊
    /// </summary>
    public string? 查核項目_一般標示_廠商資訊_合格與否 { get; set; }

    /// <summary>
    /// 查核項目:一般標示-有效日期
    /// </summary>
    public string? 查核項目_一般標示_有效日期_合格與否 { get; set; }

    /// <summary>
    /// 查核項目:其他-標示「食品」字樣
    /// </summary>
    public string? 查核項目_其他_標示食品_合格與否 { get; set; }

    /// <summary>
    /// 查核項目:其他-原產地標示
    /// </summary>
    public string? 查核項目_其他_原產地標示_合格與否 { get; set; }

    /// <summary>
    /// 查核項目:其他-符合未涉及醫療效能
    /// </summary>
    public string? 查核項目_其他_符合未涉及醫療效能_合格與否 { get; set; }

    /// <summary>
    /// 查核項目:其他-符合未涉及不實，誇張或易生誤解之情形
    /// </summary>
    public string? 查核項目_其他_符合未涉及不實_誇張或易生誤解之情形_合格與否 { get; set; }

    /// <summary>
    /// 查核項目:其他-有無含維生素者應標示「多食無益」等同義詞句
    /// </summary>
    public string? 查核項目_其他_含維生素者應標示多食無益等同義詞句 { get; set; }

    /// <summary>
    /// 查核項目:其他-含維生素者應標示「多食無益」等同義詞句
    /// </summary>
    public string? 查核項目_其他_含維生素者應標示多食無益等同義詞句_合格與否 { get; set; }

    /// <summary>
    /// 查核項目:其他-說明
    /// </summary>
    public string? 查核項目_其他_說明 { get; set; }

    /// <summary>
    /// 查核項目:有無營養標示
    /// </summary>
    public string? 查核項目_營養標示 { get; set; }

    /// <summary>
    /// 查核項目:營養標示
    /// </summary>
    public string? 查核項目_營養標示_合格與否 { get; set; }

    /// <summary>
    /// 查核項目:營養標示-說明
    /// </summary>
    public string? 查核項目_營養標示_說明 { get; set; }

    /// <summary>
    /// 查核項目:行銷規範
    /// </summary>
    public string? 查核項目_行銷規範 { get; set; }

    /// <summary>
    /// 查核項目:行銷規範-查核結果
    /// </summary>
    public string? 查核項目_行銷規範_查核結果 { get; set; }

    /// <summary>
    /// 查核項目:行銷規範-說明
    /// </summary>
    public string? 查核項目_行銷規範_說明 { get; set; }

    /// <summary>
    /// 查核項目-營養成分含量符合性
    /// </summary>
    public string? 查核項目_營養成分含量符合性 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    /// <summary>
    /// 產品限期回收改正日期
    /// </summary>
    public string? 處理情形_產品限期回收改正日期 { get; set; }

    public string? 查核登記產品清單ID檢體編號 { get; set; }

    /// <summary>
    /// 請業者說明
    /// </summary>
    public string? 請業者說明 { get; set; }

    public int? 前一次稽查主鍵 { get; set; }

    public int? 複查筆數 { get; set; }

    public int? 最初稽查主鍵 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public DateOnly? 建立日期 { get; set; }

    public string? 是否移出 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public virtual ICollection<查驗登記產品保健功效成分檢驗結果表> 查驗登記產品保健功效成分檢驗結果表s { get; set; } = new List<查驗登記產品保健功效成分檢驗結果表>();

    public virtual 查驗登記產品查核主表? 查驗登記產品查核主表主鍵Navigation { get; set; }

    public virtual ICollection<查驗登記產品營養素含量檢驗結果表> 查驗登記產品營養素含量檢驗結果表s { get; set; } = new List<查驗登記產品營養素含量檢驗結果表>();

    public virtual ICollection<查驗登記產品衛生標準檢驗結果表> 查驗登記產品衛生標準檢驗結果表s { get; set; } = new List<查驗登記產品衛生標準檢驗結果表>();

    public virtual ICollection<查驗登記產品違反法條表> 查驗登記產品違反法條表s { get; set; } = new List<查驗登記產品違反法條表>();
}
