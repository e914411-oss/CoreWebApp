using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_WSVC_CHKLABEL
{
    public int? Check_List_ID { get; set; }

    public int 物品稽查編號 { get; set; }

    public int? TPEPK { get; set; }

    public string? FLAG { get; set; }

    public string? ORG { get; set; }

    public string? CHKNO { get; set; }

    public string? BUSNO { get; set; }

    public string BMT_NO { get; set; } = null!;

    public string PJNO { get; set; } = null!;

    public string? DAYLINE { get; set; }

    public string? CHKDATE { get; set; }

    public string? 備註 { get; set; }

    public string? 受檢業者代表人 { get; set; }

    public string? COMMAN { get; set; }

    public string? TEXTNO { get; set; }

    public string? SHOWFLAG { get; set; }

    public string? CHKGENSRC { get; set; }

    public string? DELFLAG { get; set; }

    public string? CRTDATE { get; set; }

    public string? MODDATE { get; set; }

    public string? MODUSERID { get; set; }

    public string MODUSERNAME { get; set; } = null!;

    public string? 物品編號 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? Z_NO { get; set; }

    public string? 產品別主分類編號 { get; set; }

    public string? 產品別次分類編號 { get; set; }

    public string? 產品別細分類編號 { get; set; }

    public string? CHKNUM { get; set; }

    public string? NUM { get; set; }

    public string? MBUSNO { get; set; }

    public string? ORGBUSNO { get; set; }

    public string? VALIDDATE { get; set; }

    public string? 品名 { get; set; }

    public string? 內容物名稱 { get; set; }

    public string? 內容物重量容量或數量 { get; set; }

    public string? 食品添加物名稱 { get; set; }

    public string? 廠商名稱 { get; set; }

    public string? 廠商地址 { get; set; }

    public string? 廠商電話 { get; set; }

    public string? 有效日期 { get; set; }

    public string? 乳品類原料名稱 { get; set; }

    public string? 乳品類保存期限及保存條件 { get; set; }

    public string? 食品添加物許可証字號 { get; set; }

    public string? 食品添加物使用食品範圍用量及限制 { get; set; }

    public string? 食品添加物字樣 { get; set; }

    public string? 冷凍食品類別 { get; set; }

    public string? 冷凍食品保存方法及條件 { get; set; }

    public string? 冷凍食品調理方法_需調理供食者 { get; set; }

    public string? 食品字樣_錠狀膠曩狀產品 { get; set; }

    public string? 酸度及使用方法_合成食醋 { get; set; }

    public string? 警語 { get; set; }

    public string? 無中文標示 { get; set; }

    public string? 標示涉不實_誇張_易生誤解_醫療效能 { get; set; }

    public string? 逾有效日期_保存期限 { get; set; }

    public string? 塗改有效日期_製造日期_保存期限 { get; set; }

    public string? 乳品類品名 { get; set; }

    public string? 乳品類鮮乳與保久乳標示原則 { get; set; }

    public string? 咖啡因標示_飲料類產品 { get; set; }

    public string? 營養標示內容 { get; set; }

    public string? 營養宣稱 { get; set; }

    public string? 其他 { get; set; }

    public string? 標示違反法條_食管法第十一條 { get; set; }

    public string? 違反法條_食品安全衛生管理法第二十二條第一項 { get; set; }

    public string? 違反法條_食品安全衛生管理法第二十二條第二項 { get; set; }

    public string? 違反法條_食品安全衛生管理法第二十八條第一項 { get; set; }

    public string? 違反法條_食品安全衛生管理法第二十八條第二項 { get; set; }

    public string? 違反法條_健康食品管理法第六條 { get; set; }

    public string? 違反法條_健康食品管理法第十三條 { get; set; }

    public string? 違反法條_健康食品管理法第十四條 { get; set; }

    public string? 違反法條_其他法律 { get; set; }

    public string? 處理情形_移送法院 { get; set; }

    public string? 標示處理情形_罰鍰金額 { get; set; }

    public string? 處理情形_國曆限期改善日期 { get; set; }

    public string? 處理情形_沒入銷毀件數 { get; set; }

    public string 移外縣市編號 { get; set; } = null!;

    public string INCOUNTRY { get; set; } = null!;

    public string FMS備註 { get; set; } = null!;

    public string FMS違規情節描述 { get; set; } = null!;

    public string FMS處理情形 { get; set; } = null!;

    public string? SEND_DATE { get; set; }

    public string? SEND_TEXTNO { get; set; }

    public string? RECEIVE_DATE { get; set; }

    public string? RECEIVE_TEXTNO { get; set; }

    public string? BACKFLAG { get; set; }

    public string? BACKSRC { get; set; }

    public string? CHKMAN { get; set; }

    public string? FMAN { get; set; }

    public string? AUDMAN { get; set; }

    public string? 作業階段 { get; set; }

    public string? OPID { get; set; }

    public string? FINISHED { get; set; }

    public string? FDATE { get; set; }

    public string? SORG { get; set; }
}
