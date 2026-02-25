using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_物品稽查紀錄
{
    public int 物品稽查編號 { get; set; }

    public int 稽查事件流水編號 { get; set; }

    public string? 稽查物品註記_抽驗稽查 { get; set; }

    public string? 稽查物品註記_熟食稽查 { get; set; }

    public string? 稽查物品註記_標示稽查 { get; set; }

    public string? 專案名稱代碼 { get; set; }

    public string? 產品別主類別 { get; set; }

    public string? 產品別次類別 { get; set; }

    public string? 產品別細類別 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 物品編號 { get; set; }

    public string? 物品重量 { get; set; }

    public string? 物品重量單位 { get; set; }

    public string? 物品外觀 { get; set; }

    public string? 物品單位 { get; set; }

    public string? 物品保存狀況 { get; set; }

    public string? 物品包裝 { get; set; }

    public DateOnly? 物品抽驗_製造日期 { get; set; }

    public string? 物品製造日期_民國年_ { get; set; }

    public string? 物品製造日期未標示 { get; set; }

    public DateOnly? 物品抽驗_有效日期 { get; set; }

    public string? 物品有效日期_民國年_ { get; set; }

    public string? 物品有效日期未標示 { get; set; }

    public string? 物品批號 { get; set; }

    public string? 物品抽驗_稽查件數 { get; set; }

    public string? 物品抽驗_違規件數 { get; set; }

    public string? 製造商業者_縣市別_ { get; set; }

    public string? 製造商名稱 { get; set; }

    public string? 製造商電話 { get; set; }

    public string? 製造商地址 { get; set; }

    public string? 食品地區別 { get; set; }

    public string? 原產地 { get; set; }

    public string? 是否標示原產地 { get; set; }

    public string? 原產地證明 { get; set; }

    public string? 來源商名稱 { get; set; }

    public string? 來源商電話 { get; set; }

    public string? 來源商地址 { get; set; }

    public string? 備註2 { get; set; }

    public string? 熟食稽查_稽查件數 { get; set; }

    public string? 熟食稽查_違規件數 { get; set; }

    public string? 熟食稽查記錄 { get; set; }

    public string? 抽查作業記錄 { get; set; }

    public string? 結案 { get; set; }

    public string? 轉LIMS檢驗 { get; set; }

    public string? 備註1 { get; set; }

    public string? 酸價_快篩_ { get; set; }

    public string? 酸價_快篩__快篩結果 { get; set; }

    public string? 總極性物質_快篩_ { get; set; }

    public string? 總極性物質_快篩__快篩結果 { get; set; }

    public string? 熟食稽查案件狀態 { get; set; }

    public string? 熟食稽查案件負責人 { get; set; }

    public string? 酸價_登錄油炸油檢驗結果_ { get; set; }

    public string? 酸價_合不合格_登錄油炸油檢驗結果_ { get; set; }

    public string? 總極性物質_登錄油炸油檢驗結果_ { get; set; }

    public string? 總極性物質_合不合格_登錄油炸油檢驗結果_ { get; set; }

    public int? 油炸油檢驗件數 { get; set; }

    public int? 油炸油違規件數 { get; set; }

    public string? 熟食稽查稽查員 { get; set; }

    public string? 熟食稽查承辦員 { get; set; }

    public string? 熟食稽查審查員 { get; set; }

    public string? 熟食稽查結案日期 { get; set; }

    public double? 總極性物質_快篩__檢驗值 { get; set; }

    public double? 酸價_快篩__檢驗值 { get; set; }

    public double? 總極性物質_檢驗值 { get; set; }

    public string? 專案名稱 { get; set; }

    public string? 油炸油稽查案件狀態 { get; set; }

    public string? 油炸油稽查案件負責人 { get; set; }

    public string? 油炸油稽查稽查員 { get; set; }

    public string? 油炸油稽查承辦員 { get; set; }

    public string? 油炸油稽查審查員 { get; set; }

    public string? 油炸油稽查結案日期 { get; set; }

    public string? 油炸油稽查結案註記 { get; set; }

    public string? 油炸油_稽查件數 { get; set; }

    public string? 產品認證GMP { get; set; }

    public string? 產品認證CAS { get; set; }

    public string? 物品批號未標示 { get; set; }

    public string? 產品認證TAP { get; set; }

    public string? 產品認證OTAP { get; set; }

    public string? 產品認證UTAP { get; set; }

    public string? 產品認證Organic { get; set; }

    public string? 產品認證其他 { get; set; }

    public DateOnly? 熟食稽查登打日期 { get; set; }

    public DateOnly? 油炸油稽查登打日期 { get; set; }

    public DateTime? 介面異動時間 { get; set; }

    public string? 介面異動者 { get; set; }
}
