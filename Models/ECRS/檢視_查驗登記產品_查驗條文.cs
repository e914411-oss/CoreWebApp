using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_查驗登記產品_查驗條文
{
    public int 查驗登記工廠條文代碼表主鍵 { get; set; }

    public int? 編號_1 { get; set; }

    public int? 編號_2 { get; set; }

    public string? 標題 { get; set; }

    public string? 條款內容 { get; set; }

    public int? 符合性要求嚴格度判定參考 { get; set; }

    public bool? 文件審查 { get; set; }

    public bool? 現場查驗 { get; set; }
}
