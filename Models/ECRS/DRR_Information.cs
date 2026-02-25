using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class DRR_Information
{
    /// <summary>
    /// 藥品回收資訊ID
    /// </summary>
    public int DRR_Information_ID { get; set; }

    /// <summary>
    /// 藥品回收專案ID
    /// </summary>
    public int? Project_Id { get; set; }

    /// <summary>
    /// 藥品回收_發文日期
    /// </summary>
    public DateOnly? Doc_Date { get; set; }

    /// <summary>
    /// 藥品回收_發文字號
    /// </summary>
    public string? Doc_Number { get; set; }

    /// <summary>
    /// 藥品回收_藥品品名
    /// </summary>
    public string? Product_Name { get; set; }

    /// <summary>
    /// 藥品回收_藥品許可證字號
    /// </summary>
    public string? license_Id { get; set; }

    /// <summary>
    /// 藥品回收_回收批號
    /// </summary>
    public string? Lot_No { get; set; }

    /// <summary>
    /// 藥品回收_許可證持有者
    /// </summary>
    public string? License_Owner { get; set; }

    /// <summary>
    /// 藥品回收_製造商
    /// </summary>
    public string? Factory_Name { get; set; }

    /// <summary>
    /// 藥品回收_回收原因
    /// </summary>
    public string? Recycle_Reason { get; set; }

    /// <summary>
    /// 新增時間
    /// </summary>
    public DateTime? AddDate { get; set; }

    /// <summary>
    /// 新增人員
    /// </summary>
    public string? AddUser { get; set; }

    /// <summary>
    /// 異動時間
    /// </summary>
    public DateTime? ModDate { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? ModUser { get; set; }
}
