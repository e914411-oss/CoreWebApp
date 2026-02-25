using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒陳判結果判定類別檔
{
    public int 陳判結果類別檔編號 { get; set; }

    public string 主類別名稱 { get; set; } = null!;

    public string 項目名稱 { get; set; } = null!;

    public int? 陳判結果父類別編號 { get; set; }

    public long 是否有子階層 { get; set; }

    public long 是否啟用 { get; set; }

    public long 是否可輸入文字 { get; set; }

    public int? 排序 { get; set; }

    public DateTime 修改時間 { get; set; }

    public int? 報表排序 { get; set; }
}
