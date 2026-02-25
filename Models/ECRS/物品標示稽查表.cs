using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 物品標示稽查表
{
    public int 物品標示編號 { get; set; }

    public int 物品稽查編號 { get; set; }

    /// <summary>
    /// 物品標示稽查類別
    /// </summary>
    public string? 物品標示類別 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(一般標示)
    /// </summary>
    public string? 有容器或包裝食品_一般標示 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(一般標示)-品名
    /// </summary>
    public string? 有容器或包裝食品_一般標示_品名_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(一般標示)-內容物
    /// </summary>
    public string? 有容器或包裝食品_一般標示_內容物_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(一般標示)-重量容量或數量
    /// </summary>
    public string? 有容器或包裝食品_一般標示_重量容量或數量_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(一般標示)-食品添加物
    /// </summary>
    public string? 有容器或包裝食品_一般標示_食品添加物_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(一般標示)-廠商資訊
    /// </summary>
    public string? 有容器或包裝食品_一般標示_廠商資訊_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(一般標示)-有效日期(及公告須另標示事項)
    /// </summary>
    public string? 有容器或包裝食品_一般標示_有效日期_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(營養標示)
    /// </summary>
    public string? 有容器或包裝食品_營養標示 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(營養標示)-營養標示
    /// </summary>
    public string? 有容器或包裝食品_營養標示_營養標示_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無食品原產地
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_食品原產地 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-食品原產地
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_食品原產地_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無原料原產地(牛肉及牛可食部份)
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_原料原產地 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-原料原產地(牛肉及牛可食部份)
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_原料原產地_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無果蔬汁原汁含有率標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_果蔬汁原汁含有率標示 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-果蔬汁原汁含有率標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_果蔬汁原汁含有率標示_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無咖啡因標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_咖啡因標示 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-咖啡因標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_咖啡因標示_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無素食標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_素食標示 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-素食標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_素食標示_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無速食麵標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_速食麵標示 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-速食麵標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_速食麵標示_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無調合油品名標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_調合油品名標示 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-調合油品名標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_調合油品名標示_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無真空包裝食品
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_真空包裝食品 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-真空包裝食品
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_真空包裝食品_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無包裝減鈉鹽食品
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_包裝減鈉鹽食品 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-包裝減鈉鹽食品
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_包裝減鈉鹽食品_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無冬蟲夏草菌絲體食品
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_冬蟲夏草菌絲體食品 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-冬蟲夏草菌絲體食品
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_冬蟲夏草菌絲體食品_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無鮮乳保久乳調味乳品名標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_鮮乳保久乳調味乳品名標示 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-鮮乳保久乳調味乳品名標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_鮮乳保久乳調味乳品名標示_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無全穀產品標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_全穀產品標示 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-全穀產品標示
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_全穀產品標示_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無特殊營養食品(病人用食品)
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_特殊營養食品病人用食品 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-特殊營養食品(病人用食品)
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_特殊營養食品病人用食品_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無包裝水及桶裝水
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_包裝水及桶裝水 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-包裝水及桶裝水
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_包裝水及桶裝水_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無嬰兒配方食品及較大嬰兒配方輔助食品
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_嬰兒配方食品及較大嬰兒配方輔助食品 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-嬰兒配方食品及較大嬰兒配方輔助食品
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_嬰兒配方食品及較大嬰兒配方輔助食品_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無含基因改造黃豆及玉米原料食品
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_含基因改造黃豆及玉米原料食品 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-含基因改造黃豆及玉米原料食品
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_含基因改造黃豆及玉米原料食品_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無輻射照射處理食品
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_輻射照射處理食品 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-輻射照射處理食品
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_輻射照射處理食品_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無食品原料及添加物應加標警語
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_食品原料及添加物應加標警語 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-食品原料及添加物應加標警語
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_食品原料及添加物應加標警語_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無其他
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_其他 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-其他(自填項目)
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_其他_說明 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-其他
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_其他_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-稽查件數
    /// </summary>
    public int? 稽查件數 { get; set; }

    /// <summary>
    /// 標示稽查-違規件數
    /// </summary>
    public int? 違規件數 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-有無蒟蒻成份果凍應加標警語
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_蒟蒻成份果凍應加標警語 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其他公告指定標示事項)-蒟蒻成份果凍應加標警語
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_蒟蒻成份果凍應加標警語_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-散裝食品(一般標示)-品名
    /// </summary>
    public string? 散裝食品_品名_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-散裝食品(一般標示)-食品原產地
    /// </summary>
    public string? 散裝食品_食品原產地_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-散裝食品(一般標示)-原料原產地(牛肉及牛可食部位)
    /// </summary>
    public string? 散裝食品_原料原產地_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-直接供應飲食之場所(其他公告指定標示事項)-原料原產地(牛肉及牛可食部位)
    /// </summary>
    public string? 直接供應飲食之場所_原料原產地_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(標示及廣告詞句)-有無符合涉及醫療效能
    /// </summary>
    public string? 有容器或包裝食品_標示及廣告詞句_符合未涉及不實誇張或易生誤解之情形 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(標示及廣告詞句)-符合涉及醫療效能
    /// </summary>
    public string? 有容器或包裝食品_標示及廣告詞句_符合未涉及不實誇張或易生誤解之情形_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(標示及廣告詞句)-有無符合未涉及醫療效能，但涉及誇張或易生誤解
    /// </summary>
    public string? 有容器或包裝食品_標示及廣告詞句_符合未涉及醫療效能 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(標示及廣告詞句)-符合未涉及醫療效能，但涉及誇張或易生誤解
    /// </summary>
    public string? 有容器或包裝食品_標示及廣告詞句_符合未涉及醫療效能_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(營養標示)-營養宣稱
    /// </summary>
    public string? 有容器或包裝食品_營養標示_營養宣稱_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(標示及廣告詞句)
    /// </summary>
    public string? 有容器或包裝食品_標示及廣告詞句 { get; set; }

    /// <summary>
    /// 標示稽查-散裝食品(一般標示)-有無原料原產地(牛肉及牛可食部位)
    /// </summary>
    public string? 散裝食品_原料原產地_牛肉及牛可食部位 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其它)
    /// </summary>
    public string? 有容器或包裝食品_其它 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其它)-有無屠宰衛生檢查合格標誌或相關來源證明資料(協助農政機關)
    /// </summary>
    public string? 有容器或包裝食品_其它_屠宰衛生檢查合格標誌或相關來源證明資料 { get; set; }

    /// <summary>
    /// 標示稽查-有容器或包裝食品(其它)-屠宰衛生檢查合格標誌或相關來源證明資料(協助農政機關)
    /// </summary>
    public string? 有容器或包裝食品_其它_屠宰衛生檢查合格標誌或相關來源證明資料_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-散裝食品(一般標示)-有無屠宰衛生檢查合格標誌或相關來源證明資料(協助農政機關 )
    /// </summary>
    public string? 散裝食品_屠宰衛生檢查合格標誌或相關來源證明資料 { get; set; }

    /// <summary>
    /// 標示稽查-散裝食品(一般標示)-屠宰衛生檢查合格標誌或相關來源證明資料(協助農政機關 )
    /// </summary>
    public string? 散裝食品_屠宰衛生檢查合格標誌或相關來源證明資料_合格與否 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public string? 品名 { get; set; }

    public string? 內容物名稱 { get; set; }

    public string? 內容物重量容量或數量 { get; set; }

    public string? 食品添加物名稱 { get; set; }

    public string? 廠商名稱 { get; set; }

    public string? 廠商地址 { get; set; }

    public string? 廠商電話 { get; set; }

    public string? 國內負責廠商名稱 { get; set; }

    public string? 國內負責廠商地址 { get; set; }

    public string? 國內負責廠商電話號碼 { get; set; }

    public string? 有效日期 { get; set; }

    public string? 乳品類工廠登記証字號 { get; set; }

    public string? 乳品類原料名稱 { get; set; }

    public string? 乳品類成分乳脂 { get; set; }

    public string? 乳品類成分乳固形物 { get; set; }

    public string? 乳品類保存期限及保存條件 { get; set; }

    public string? 食品添加物許可証字號 { get; set; }

    public string? 食品添加物使用食品範圍用量及限制 { get; set; }

    public string? 食品添加物字樣 { get; set; }

    public string? 冷凍食品類別 { get; set; }

    public string? 冷凍食品保存方法及條件 { get; set; }

    public string? 冷凍食品調理方法 { get; set; }

    public string? 食品字樣_錠狀膠曩狀產品 { get; set; }

    public string? 酸度及使用方法_合成食醋 { get; set; }

    public string? 分裝廠商名稱 { get; set; }

    public string? 分裝廠商地址 { get; set; }

    public string? 警語 { get; set; }

    public string? 無中文標示 { get; set; }

    public string? 標示涉不實_誇張_易生誤解_醫療效能 { get; set; }

    public string? 逾有效日期 { get; set; }

    public string? 塗改有效日期_製造日期_保存期限 { get; set; }

    public string? 營養標示內容 { get; set; }

    public string? 營養宣稱 { get; set; }

    public string? 其他 { get; set; }

    public string? 其他描述 { get; set; }

    /// <summary>
    /// 標示稽查-食品添加物-品名及「食品添加物」字樣
    /// </summary>
    public string? 食品添加物_品名及食品添加物字樣_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-食品添加物-食品添加物名稱
    /// </summary>
    public string? 食品添加物_食品添加物名稱_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-食品添加物-淨重、容量或數量
    /// </summary>
    public string? 食品添加物_淨重容量或數量_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-食品添加物-廠商資訊
    /// </summary>
    public string? 食品添加物_廠商資訊_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-食品添加物-有效日期
    /// </summary>
    public string? 食品添加物_有效日期_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-食品添加物-使用範圍、用量標準及使用限制
    /// </summary>
    public string? 食品添加物_使用範圍用量標準及使用限制_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-食品添加物-原產地（國）
    /// </summary>
    public string? 食品添加物_原產地國_合格與否 { get; set; }

    /// <summary>
    /// 標示稽查-食品添加物-有無米粉絲產品標示原則
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_米粉絲產品標示原則 { get; set; }

    /// <summary>
    /// 標示稽查-食品添加物-米粉絲產品標示原則
    /// </summary>
    public string? 有容器或包裝食品_其他公告指定標示事項_米粉絲產品標示原則_合格與否 { get; set; }

    public string? 直接供應飲食之場所_火鍋類食品之湯底標示_合格與否 { get; set; }

    public string? 直接供應飲食之場所_食品含基因改造食品原料標示_合格與否 { get; set; }

    public string? 直接供應飲食之場所_重組肉品名標示_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_市售包裝冷凍食品標示 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_食品過敏原標示 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_重組肉品名標示 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_真菌類食品標示 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_國內通過農產品生產驗證者應標示可追溯來源 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_牛樟芝食品管理及標示 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_包裝食品與玩具併同販售應標示醒語 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_包裝食用鹽品之氟標示 { get; set; }

    public string? 有容器或包裝食品_其它_包裝食品與玩具併同販售應標示醒語規定 { get; set; }

    public string? 散裝食品_基因改造食品原料標示 { get; set; }

    public string? 散裝食品_國內通過農產品生產驗證標示 { get; set; }

    public string? 直接供應飲食之場所_現場調製飲料標示 { get; set; }

    public string? 食品添加物_內容物 { get; set; }

    public string? 食品添加物_單方許可證字號 { get; set; }

    public string? 食品添加物_產品登錄碼 { get; set; }

    public string? 食品添加物_基因改造食品原料標示 { get; set; }

    public string? 食品用器具_品名 { get; set; }

    public string? 食品用器具_材質名稱 { get; set; }

    public string? 食品用器具_耐熱溫度 { get; set; }

    public string? 食品用器具_淨重容量或數量 { get; set; }

    public string? 食品用器具_廠商資訊 { get; set; }

    public string? 食品用器具_原產地 { get; set; }

    public string? 食品用器具_製造日期 { get; set; }

    public string? 食品用器具_其他注意事項或警語 { get; set; }

    public string? 食品用洗潔劑_品名 { get; set; }

    public string? 食品用洗潔劑_主要成分之化學名稱 { get; set; }

    public string? 食品用洗潔劑_淨重或容量 { get; set; }

    public string? 食品用洗潔劑_國內負責廠商之名稱電話號碼及地址 { get; set; }

    public string? 食品用洗潔劑_原產地 { get; set; }

    public string? 食品用洗潔劑_製造日期 { get; set; }

    public string? 食品用洗潔劑_適用對象或用途 { get; set; }

    public string? 食品用洗潔劑_使用方法及使用注意發項或警語 { get; set; }

    public string? 食品用洗潔劑_其他經中央主管機關公告之事項 { get; set; }
}
