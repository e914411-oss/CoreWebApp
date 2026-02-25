using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 訂席_外燴定型化契約條款稽查結果
{
    public int 系統識別碼 { get; set; }

    public int 訂席_外燴定型化契約稽查序號 { get; set; }

    public int 條款ID { get; set; }

    public string 結果 { get; set; } = null!;

    public string 備註 { get; set; } = null!;

    public DateTime 建立日期 { get; set; }

    public string 建立人員 { get; set; } = null!;

    public DateTime 更新日期 { get; set; }

    public string 更新人員 { get; set; } = null!;
}
