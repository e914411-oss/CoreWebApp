using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_物品稽查_新搜尋清單
{
    public int 物品稽查編號 { get; set; }

    public int? Check_List_ID { get; set; }

    public int? Industry_ID { get; set; }

    public string? Signboard_Name { get; set; }

    public string? Business_Address { get; set; }

    public string? Telephone { get; set; }

    public string? Responsible_Person_Name { get; set; }

    public string? Company_Tax_ID { get; set; }

    public string? Factory_Reg_ID { get; set; }

    public string? ProjectNames { get; set; }

    public string? 產品別主分類名稱 { get; set; }

    public string? 產品別次分類名稱 { get; set; }

    public string? 產品別細分類名稱 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 物品編號 { get; set; }

    public string? Food_region { get; set; }

    public string? Food_Origin { get; set; }

    public string? 原產地證明 { get; set; }

    public string? 來源商名稱 { get; set; }

    public string? 來源商編號 { get; set; }

    public string? 來源商地址 { get; set; }

    public string? 來源商電話 { get; set; }

    public string? 製造商名稱 { get; set; }

    public string? 製造商編號 { get; set; }

    public string? 製造商地址 { get; set; }

    public string? 製造商電話 { get; set; }

    public string? 抽驗稽查 { get; set; }

    public string? 標示稽查 { get; set; }

    public string? 熟食稽查 { get; set; }

    public string? inspectors_dispose { get; set; }

    public string? undertakers_dispose { get; set; }

    public string? reviewers_dispose { get; set; }

    public string? status_dispose { get; set; }

    public string? closingDate_dispose { get; set; }

    public string? 物品重量 { get; set; }

    public int? 物品重量單位代碼 { get; set; }

    public int? 物品外觀代碼 { get; set; }

    public int? 物品單位代碼 { get; set; }

    public int? 物品保存狀況代碼 { get; set; }

    public int? 物品包裝代碼 { get; set; }

    public string? 物品批號 { get; set; }

    public string? 國曆物品製造日期 { get; set; }

    public string? 物品製造日期未標示 { get; set; }

    public string? 國曆物品有效日期 { get; set; }

    public string? 物品有效日期未標示 { get; set; }

    public string? 抽驗_稽查件數 { get; set; }

    public string? 抽驗_違規件數 { get; set; }

    public string? 油炸油_酸價快篩 { get; set; }

    public string? 油炸油_酸價快篩_快篩結果 { get; set; }

    public string? 油炸油_總極性物質快篩 { get; set; }

    public string? 油炸油_總極性物質快篩_快篩結果 { get; set; }

    public string? 油炸油_酸價_登錄油炸油檢驗結果 { get; set; }

    public string? 油炸油_酸價_合不合格_登錄油炸油檢驗結果 { get; set; }

    public string? 油炸油_總極性物質_登錄油炸油檢驗結果 { get; set; }

    public string? 油炸油_總極性物質_合不合格_登錄油炸油檢驗結果 { get; set; }

    public string? Violated_Law_dispose { get; set; }

    public string? 抽驗處理情形_移送法院 { get; set; }

    public string? 抽驗處理情形_限期改善 { get; set; }

    public string? 抽驗處理情形_國曆限期改善日期 { get; set; }

    public string? 處理情形_飭其收回重製 { get; set; }

    public string? 處理情形_禁止出售或沒收 { get; set; }

    public string? 處理情形_停業 { get; set; }

    public string? OUTCOUNTRY_CHK_dispose { get; set; }

    public string? 處理情形_罰款金額 { get; set; }

    public string? 處理情形_廢棄重量_公斤 { get; set; }

    public string? outcity_number_dispose { get; set; }

    public string? outcity_date_dispose { get; set; }

    public string? OUTCOUNTRY_dispose { get; set; }

    public string? outcity_industry_dispose { get; set; }

    public string? outcity_person_dispose { get; set; }

    public string? outcity_address_dispose { get; set; }

    public string? outcity_reason_dispose { get; set; }

    public string? NOTATION_dispose { get; set; }

    public string? inspectors_label { get; set; }

    public string? undertakers_label { get; set; }

    public string? reviewers_label { get; set; }

    public string? status_label { get; set; }

    public string? closingDate_label { get; set; }

    public int? InspectionNumber_label { get; set; }

    public int? ViolationNumber_label { get; set; }

    public string? 物品標示類別 { get; set; }

    public string? 有容器或包裝食品_一般標示 { get; set; }

    public string? 有容器或包裝食品_一般標示_品名_合格與否 { get; set; }

    public string? 有容器或包裝食品_一般標示_內容物_合格與否 { get; set; }

    public string? 有容器或包裝食品_一般標示_重量容量或數量_合格與否 { get; set; }

    public string? 有容器或包裝食品_一般標示_食品添加物_合格與否 { get; set; }

    public string? 有容器或包裝食品_一般標示_廠商資訊_合格與否 { get; set; }

    public string? 有容器或包裝食品_一般標示_有效日期_合格與否 { get; set; }

    public string? 有容器或包裝食品_營養標示 { get; set; }

    public string? 有容器或包裝食品_營養標示_營養標示_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_食品原產地 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_食品原產地_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_原料原產地 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_原料原產地_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_果蔬汁原汁含有率標示 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_果蔬汁原汁含有率標示_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_咖啡因標示 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_咖啡因標示_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_素食標示 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_素食標示_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_速食麵標示 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_速食麵標示_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_調合油品名標示 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_調合油品名標示_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_真空包裝食品 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_真空包裝食品_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_包裝減鈉鹽食品 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_包裝減鈉鹽食品_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_冬蟲夏草菌絲體食品 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_冬蟲夏草菌絲體食品_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_鮮乳保久乳調味乳品名標示 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_鮮乳保久乳調味乳品名標示_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_全穀產品標示 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_全穀產品標示_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_特殊營養食品病人用食品 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_特殊營養食品病人用食品_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_包裝水及桶裝水 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_包裝水及桶裝水_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_嬰兒配方食品及較大嬰兒配方輔助食品 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_嬰兒配方食品及較大嬰兒配方輔助食品_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_含基因改造黃豆及玉米原料食品 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_含基因改造黃豆及玉米原料食品_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_輻射照射處理食品 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_輻射照射處理食品_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_食品原料及添加物應加標警語 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_食品原料及添加物應加標警語_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_蒟蒻成份果凍應加標警語 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_蒟蒻成份果凍應加標警語_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_其他 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_其他_說明 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_其他_合格與否 { get; set; }

    public string? 散裝食品_品名_合格與否 { get; set; }

    public string? 散裝食品_食品原產地_合格與否 { get; set; }

    public string? 散裝食品_原料原產地_合格與否 { get; set; }

    public string? 直接供應飲食之場所_原料原產地_合格與否 { get; set; }

    public string? 標示違反法條_食管法第十一條 { get; set; }

    public string? 違反法條_食品安全衛生管理法第二十二條第一項 { get; set; }

    public string? 違反法條_食品安全衛生管理法第二十二條第二項 { get; set; }

    public string? 違反法條_食品安全衛生管理法第二十八條第一項 { get; set; }

    public string? 違反法條_食品安全衛生管理法第二十八條第二項 { get; set; }

    public string? 違反法條_健康食品管理法第六條 { get; set; }

    public string? 違反法條_健康食品管理法第十三條 { get; set; }

    public string? 違反法條_健康食品管理法第十四條 { get; set; }

    public string? 違反法條_其他法律 { get; set; }

    public string? 標示處理情形_移送法院 { get; set; }

    public string? 標示處理情形_限期改善 { get; set; }

    public string? 標示處理情形_國曆限期改善日期 { get; set; }

    public string? OUTCOUNTRY_CHK_label { get; set; }

    public string? 標示處理情形_罰鍰金額 { get; set; }

    public string? 處理情形_沒入銷毀件數 { get; set; }

    public string? outcity_number_label { get; set; }

    public string? outcity_date_label { get; set; }

    public string? OUTCOUNTRY_label { get; set; }

    public string? outcity_industry_label { get; set; }

    public string? outcity_person_label { get; set; }

    public string? outcity_address_label { get; set; }

    public string? outcity_reason_label { get; set; }

    public string? 承辦備註說明 { get; set; }

    public string? 熟食_稽查人員編號 { get; set; }

    public string? 熟食_承辦人員編號 { get; set; }

    public string? 熟食_審查人員編號 { get; set; }

    public string? 熟食_作業階段 { get; set; }

    public string? 熟食_結案日期 { get; set; }

    public string? 熟食_稽查件數 { get; set; }

    public string? 熟食_違規件數 { get; set; }

    public string? 熟食_稽查記錄 { get; set; }
}
