using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 定型化契約條款內容
{
    public int 條款ID { get; set; }

    public string 適用於哪種契約 { get; set; } = null!;

    public string 條款類型 { get; set; } = null!;

    public string 條款內容 { get; set; } = null!;

    public int 上一階條款ID { get; set; }

    public string 只顯示內容 { get; set; } = null!;

    public string 是否啟用 { get; set; } = null!;

    public int 排序 { get; set; }

    public DateTime 建立日期 { get; set; }

    public string 建立人員 { get; set; } = null!;

    public DateTime 更新日期 { get; set; }

    public string 更新人員 { get; set; } = null!;
}
