using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒攝食場所明細表
{
    /// <summary>
    /// 中毒攝食場所及食品供應商
    /// </summary>
    public int 食品中毒攝食場所明細表_主鍵 { get; set; }

    /// <summary>
    /// 資料界接外部Key
    /// </summary>
    public int? FMS介接主鍵 { get; set; }

    /// <summary>
    /// 中毒主檔ID
    /// </summary>
    public int? 食品中毒速報主表主鍵 { get; set; }

    /// <summary>
    /// 攝食場所名稱
    /// </summary>
    public string? 攝食場所名稱 { get; set; }

    /// <summary>
    /// 攝食地點-縣市
    /// </summary>
    public string? 攝食地點_縣市 { get; set; }

    /// <summary>
    /// 攝食地點-地址
    /// </summary>
    public string? 攝食地點_地址 { get; set; }

    /// <summary>
    /// 攝食場所類別代碼(逗號分隔)
    /// </summary>
    public string? 攝食場所類別代碼 { get; set; }

    /// <summary>
    /// 攝食場所類別-其他說明
    /// </summary>
    public string? 攝食場所類別_其他說明 { get; set; }

    /// <summary>
    /// 食品供應商
    /// </summary>
    public string? 食品供應商 { get; set; }

    /// <summary>
    /// 食品供應商縣市
    /// </summary>
    public string? 食品供應商縣市 { get; set; }

    /// <summary>
    /// 食品供應商地址
    /// </summary>
    public string? 食品供應商地址 { get; set; }

    /// <summary>
    /// 攝食日期時間
    /// </summary>
    public DateTime? 攝食日期 { get; set; }

    /// <summary>
    /// 攝食日期民國年月日
    /// </summary>
    public string? 攝食日期民國日 { get; set; }

    /// <summary>
    /// 攝食時間
    /// </summary>
    public string? 攝食日期時分 { get; set; }

    /// <summary>
    /// 攝食地點郵遞區號
    /// </summary>
    public string? 攝食地點_縣市郵遞區號 { get; set; }

    /// <summary>
    /// 供應商ID
    /// </summary>
    public int? 供應商代碼 { get; set; }

    public string? 判斷食品供應商是否為餐盒工廠 { get; set; }

    public string? 餐盒工廠編號 { get; set; }

    public string? 餐盒工廠是否移入待稽查狀態 { get; set; }

    /// <summary>
    /// 攝食場所類別代碼(逗號分隔)
    /// </summary>
    public string? 攝食類別_團體_類別代碼 { get; set; }

    /// <summary>
    /// 攝食場所類別-其他說明
    /// </summary>
    public string? 攝食類別_團體_其他說明 { get; set; }

    public string? 供應商為攝食場所 { get; set; }

    public string? 攝食場所登錄字號 { get; set; }

    public string? 攝食場所無登錄字號原因 { get; set; }

    public int? 攝食場所業者編號 { get; set; }

    public int? 供應廠商業者編號 { get; set; }

    public string? 供應廠商登錄字號 { get; set; }

    public string? 供應廠商無登錄字號原因 { get; set; }

    public string? 供應廠商負責人 { get; set; }

    public string? 供應廠商聯絡電話 { get; set; }

    public string? 供應廠商統一編號 { get; set; }

    public string? 攝食場所負責人 { get; set; }

    public string? 攝食場所聯絡電話 { get; set; }

    public string? 攝食場所統一編號 { get; set; }

    public int? 學校供餐類型 { get; set; }

    public string? 學校供餐類型_其他說明 { get; set; }

    public string? 患者是否皆為同班 { get; set; }

    public int? 供應廠商當日總供餐量 { get; set; }

    public double? 供應廠商至學校之路程 { get; set; }

    public string? 學制 { get; set; }

    public string? 學制_其他 { get; set; }

    public virtual 縣市代碼表? 攝食地點_縣市Navigation { get; set; }

    public virtual ICollection<食品中毒業者待稽查檔> 食品中毒業者待稽查檔s { get; set; } = new List<食品中毒業者待稽查檔>();
}
