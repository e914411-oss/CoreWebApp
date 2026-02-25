using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 一級品管稽查產品類別次表
{
    public int 識別碼 { get; set; }

    public int? 一級品管ID { get; set; }

    public int? 產品類別ID { get; set; }

    public DateOnly? 檢驗日期 { get; set; }

    public int? 最後一次強制性檢驗日期類別 { get; set; }
}
