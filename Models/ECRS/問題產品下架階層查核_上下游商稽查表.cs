using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 問題產品下架階層查核_上下游商稽查表
{
    public int 主鍵 { get; set; }

    public string 案件編號 { get; set; } = null!;

    public string? 來源資料表 { get; set; }

    public int? 來源主鍵 { get; set; }

    public int? 層數 { get; set; }

    public int? 上一層主鍵 { get; set; }

    public string? 縣市代碼 { get; set; }

    public string? 狀態 { get; set; }

    public string? 關聯多產品主鍵 { get; set; }

    public decimal? 製造量_進貨量 { get; set; }

    public decimal? 售出量 { get; set; }

    public decimal? 庫存量 { get; set; }

    public decimal? 退回上游量 { get; set; }

    public decimal? 下游退回量 { get; set; }

    public decimal? 封存量 { get; set; }

    public decimal? 其他 { get; set; }

    public string? 備註 { get; set; }

    public DateTime? 回報日期 { get; set; }

    public string? 結案狀態 { get; set; }

    public DateTime? 結案日期 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 修改人員 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public string? 非登_回收狀態 { get; set; }

    public string? 非登_退回原因 { get; set; }

    public string? 是否新增產品 { get; set; }

    public string? 非登_產品主鍵 { get; set; }
}
